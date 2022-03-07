using System.Diagnostics;
using DriveSyncDesktop.Service;

namespace DriveSyncDesktop.Forms;

public partial class MainForm : Form
{
    private Process? _httpServerProcess;

    public MainForm()
    {
        InitializeComponent();
    }

    private void backgroundWorkerForHttp_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        try
        {
            toolStripStatusLabel.Text = "Starting RClone server";
            _httpServerProcess = RCloneService.RunHttpServer();
            toolStripStatusLabel.Text = "Successfully started RClone server";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
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
        if (!backgroundWorkerForHttp.WorkerSupportsCancellation) return;

        _httpServerProcess?.Kill();
        backgroundWorkerForHttp.CancelAsync();
    }
}