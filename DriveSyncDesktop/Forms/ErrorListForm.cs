using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveSyncDesktop.Utils;

namespace DriveSyncDesktop.Forms
{
    public partial class ErrorListForm : Form
    {
        public ErrorListForm()
        {
            InitializeComponent();
        }

        private async void ErrorListForm_Load(object sender, EventArgs e)
        {
            try
            {
                var todayLogs = await LoggerUtils.LoadTodayLogs();

                if (todayLogs == null) return;

                foreach (var log in todayLogs.Where(log => !log.IsSynced))
                {
                    ListBox.Items.Add($"Time: {log.Time}, Local: {log.LocalFolderPath}, Account: {log.RemoteAccountName}, Remote path: {log.RemoteFolderPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
