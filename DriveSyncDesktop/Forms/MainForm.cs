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
            _httpServerProcess = RCloneService.RunHttpServer();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
    }

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