using System.Diagnostics;
using DriveSyncDesktop.Service;

namespace DriveSyncDesktop.Forms;

public partial class MainForm : Form
{
    private Process? _httpServerProcess;
    private readonly NotifyIcon _notifyIcon;

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
            _notifyIcon.Text = "DriveSyncDesktop";
            _notifyIcon.Visible = true;

            // Notify Icon events
            _notifyIcon.Click += _notifyIcon_Click;

            // Notify Icon Context menu strip
            //_notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            //_notifyIcon.ContextMenuStrip.Items.Add("Exit");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    // ----- Notify Icon Events Handler (not working) -----
    private void _notifyIcon_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("hkA");
    }

    // ----- Notify Icon Context menu Events Handler -----

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

    // ----- Control Events -----
    private void SettingsButton_Click(object sender, EventArgs e)
    {
        new SettingsForm().Show();
    }
}