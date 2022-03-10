using System.Diagnostics;
using DriveSyncDesktop.Models;
using DriveSyncDesktop.Service;
using DriveSyncDesktop.Utils;

namespace DriveSyncDesktop.Forms;

public partial class MainForm : Form
{
    private Process? _httpServerProcess;
    private readonly NotifyIcon _notifyIcon;
    private AppConfigModel? _appConfigModel;
    private bool _cancelSync = false;

    public MainForm()
    {
        InitializeComponent();
        _notifyIcon = new NotifyIcon();
        SetAppConfig();
    }

    // Custom function
    private async Task SetErrorCountText()
    {
        try
        {
            var todayLogs = await LoggerUtils.LoadTodayLogs();

            if (todayLogs != null)
            {
                var count = todayLogs.Count(x => x.IsSynced == false);
                ErrorCountButton.Text = $"Error Occurred Today ( {count} )";
                ErrorCountButton.ForeColor = Color.Red;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void SetAppConfig()
    {
        try
        {
            _appConfigModel = AppConfigUtils.Load();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public void SetCancelButtonText()
    {
        if (_cancelSync)
        {
            CancelButton.Text = "Cancelled";
            StartSyncButton.Enabled = false;
        }
        else
        {
            CancelButton.Text = "Cancel";
            StartSyncButton.Enabled = true;
        }
    }

    // Background workers
    private void backgroundWorkerForHttp_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        try
        {
            StartSyncButton.Enabled = false;

            toolStripStatusLabel.Text = "Starting RClone server";
            toolStripProgressBar.Value = 10;
            
            // Run RClone Server with rclone.exe file
            _httpServerProcess = RCloneService.RunHttpServer();

            toolStripProgressBar.Value = 80;
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

            toolStripProgressBar.Value = 100;

            StartSyncButton.Enabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Application.Exit();
        }
    }
    private async void backgroundWorkerForSync_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        try
        {
            if (_appConfigModel?.FolderToSyncList == null)
            {
                MessageBox.Show("Folder sync list has not been set");
                return;
            }
            if (_appConfigModel?.RepeatSync == null)
            {
                MessageBox.Show("Delay repeat time has not been set");
                return;
            }

            var timeDelay = _appConfigModel.RepeatSync ?? 60000;
            var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(timeDelay));

            do
            {
                var startSyncingTime = DateTime.Now;
                var hasError = false;
                var errors = new List<FolderToSync>();
                var queueCount = _appConfigModel.FolderToSyncList.Count;
                var progress = 0;
                var progressStep = 100 / queueCount;

                // Set status
                SyncStatusLabel.Text = "Syncing";
                toolStripStatusLabel.Text = "Syncing...";
                toolStripProgressBar.Value = progress;

                foreach (var toSync in _appConfigModel.FolderToSyncList)
                {
                    InQueueLabel.Text = queueCount.ToString();
                    // Set syncing label text
                    SyncingFolder.Text = toSync.FolderPath;
                    SyncingAccountLabel.Text = toSync.RemoteName;
                    SyncingRemotePathLabel.Text = toSync.RemotePath;

                    var isCopied = RCloneService.Copy(toSync.FolderPath, toSync.RemoteName, out _, toSync.RemotePath);

                    if (isCopied)
                    {
                        await LoggerUtils.Log(new LogModel()
                        {
                            IsSynced = true,
                            Time = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt"),
                            LocalFolderPath = toSync.FolderPath,
                            RemoteFolderPath = toSync.RemotePath,
                            RemoteAccountName = toSync.RemoteName,
                            LogLevel = LogLevel.Information
                        });
                        toolStripStatusLabel.Text = $"Success syncing {toSync.FolderPath} in {toSync.RemoteName}";

                        // Set last syncing label text
                        LastSyncFolderLabel.Text = toSync.FolderPath;
                        LastSyncFolderLabel.ForeColor = Color.LimeGreen;
                        LastSyncAccountLabel.Text = toSync.RemoteName;
                        LastSyncAccountLabel.ForeColor = Color.LimeGreen;
                        LastSyncRemotePath.Text = toSync.RemotePath;
                        LastSyncRemotePath.ForeColor = Color.LimeGreen;
                    }
                    else
                    {
                        hasError = true;

                        await LoggerUtils.Log(new LogModel()
                        {
                            IsSynced = false,
                            Time = DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss tt"),
                            LocalFolderPath = toSync.FolderPath,
                            RemoteFolderPath = toSync.RemotePath,
                            RemoteAccountName = toSync.RemoteName,
                            LogLevel = LogLevel.Error
                        });

                        await SetErrorCountText();
                    }

                    toolStripProgressBar.Value = progress;
                    progress += progressStep;
                    queueCount--;
                }

                InQueueLabel.Text = "0";
                LastSyncedLabel.Text = startSyncingTime.ToLongTimeString();
                NextSyncLabel.Text = startSyncingTime.AddMilliseconds(timeDelay).ToLongTimeString();
                SyncStatusLabel.Text = "Idle";
                toolStripStatusLabel.Text =
                    hasError ? "Synced completed with one or more errors" : "Synced completed without errors";
                toolStripProgressBar.Value = 100;

                SyncingFolder.Text = "None";
                SyncingAccountLabel.Text = "None";
                SyncingRemotePathLabel.Text = "None";
            } while (await timer.WaitForNextTickAsync() && _cancelSync == false);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    // ----- Notify Icon Events Handler (not working) -----
    private void _notifyIcon_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("hkA");
    }

    // ----- Notify Icon Context menu Events Handler -----

    // ----- Form Events -----
    private async void MainForm_Load(object sender, EventArgs e)
    {
        if (backgroundWorkerForHttp.IsBusy == false)
        {
            backgroundWorkerForHttp.RunWorkerAsync();
        }
        SetCancelButtonText();
        await SetErrorCountText();
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
        new SettingsForm(SetAppConfig).Show();
    }
    private void StartSyncButton_Click(object sender, EventArgs e)
    {
        if (backgroundWorkerForSync.IsBusy == false)
        {
            backgroundWorkerForSync.RunWorkerAsync();
        }
    }
    private void CancelButton_Click(object sender, EventArgs e)
    {
        _cancelSync = !_cancelSync;
        SetCancelButtonText();
    }
    private void ErrorCountButton_Click(object sender, EventArgs e)
    {
        new ErrorListForm().Show();
    }
}