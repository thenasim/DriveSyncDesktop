using System.Diagnostics;
using DriveSyncDesktop.Service;

namespace DriveSyncDesktop.Forms;

public partial class MainForm : Form
{
    private Process? _httpServerProcess;
    private NotifyIcon _notifyIcon;

    public MainForm()
    {
        InitializeComponent();
        _notifyIcon = new NotifyIcon();
    }

    private void backgroundWorkerForHttp_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        try
        {
            // Run RClone Server with rclone.exe file
            toolStripStatusLabel.Text = "Starting RClone server";
            _httpServerProcess = RCloneService.RunHttpServer();
            toolStripStatusLabel.Text = "Successfully started RClone server";

            // Set Notify Icon icon and set visibility true
            _notifyIcon.Icon = new Icon("Resources/favicon.ico");
            _notifyIcon.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    // ----- Form Events -----
    private void MainForm_Load(object sender, EventArgs e)
    {
        if (backgroundWorkerForHttp.IsBusy == false)
        {
            backgroundWorkerForHttp.RunWorkerAsync();
        }
    }
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _notifyIcon.Dispose();

        if (!backgroundWorkerForHttp.WorkerSupportsCancellation) return;

        _httpServerProcess?.Kill();
        backgroundWorkerForHttp.CancelAsync();
    }
}