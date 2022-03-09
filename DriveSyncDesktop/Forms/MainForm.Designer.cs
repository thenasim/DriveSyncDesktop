namespace DriveSyncDesktop.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorkerForHttp = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StartSyncButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SyncStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastSyncedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NextSyncLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InQueueLabel = new System.Windows.Forms.Label();
            this.backgroundWorkerForSync = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.SyncingFolder = new System.Windows.Forms.Label();
            this.SyncingAccountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SyncingRemotePathLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LastSyncRemotePath = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LastSyncAccountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LastSyncFolderLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ErrorCountButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerForHttp
            // 
            this.backgroundWorkerForHttp.WorkerSupportsCancellation = true;
            this.backgroundWorkerForHttp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForHttp_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 1, 4);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 18);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(45, 22);
            this.toolStripStatusLabel.Text = "None";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(680, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 29);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StartSyncButton
            // 
            this.StartSyncButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartSyncButton.Location = new System.Drawing.Point(321, 490);
            this.StartSyncButton.Name = "StartSyncButton";
            this.StartSyncButton.Size = new System.Drawing.Size(155, 53);
            this.StartSyncButton.TabIndex = 9;
            this.StartSyncButton.Text = "Start Sync";
            this.StartSyncButton.UseVisualStyleBackColor = true;
            this.StartSyncButton.Click += new System.EventHandler(this.StartSyncButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // SyncStatusLabel
            // 
            this.SyncStatusLabel.AutoSize = true;
            this.SyncStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncStatusLabel.Location = new System.Drawing.Point(119, 25);
            this.SyncStatusLabel.Name = "SyncStatusLabel";
            this.SyncStatusLabel.Size = new System.Drawing.Size(44, 28);
            this.SyncStatusLabel.TabIndex = 11;
            this.SyncStatusLabel.Text = "Idle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last synced";
            // 
            // LastSyncedLabel
            // 
            this.LastSyncedLabel.AutoSize = true;
            this.LastSyncedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSyncedLabel.Location = new System.Drawing.Point(119, 67);
            this.LastSyncedLabel.Name = "LastSyncedLabel";
            this.LastSyncedLabel.Size = new System.Drawing.Size(95, 28);
            this.LastSyncedLabel.TabIndex = 13;
            this.LastSyncedLabel.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next sync";
            // 
            // NextSyncLabel
            // 
            this.NextSyncLabel.AutoSize = true;
            this.NextSyncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextSyncLabel.Location = new System.Drawing.Point(119, 109);
            this.NextSyncLabel.Name = "NextSyncLabel";
            this.NextSyncLabel.Size = new System.Drawing.Size(95, 28);
            this.NextSyncLabel.TabIndex = 15;
            this.NextSyncLabel.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "In queue";
            // 
            // InQueueLabel
            // 
            this.InQueueLabel.AutoSize = true;
            this.InQueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InQueueLabel.Location = new System.Drawing.Point(119, 151);
            this.InQueueLabel.Name = "InQueueLabel";
            this.InQueueLabel.Size = new System.Drawing.Size(23, 28);
            this.InQueueLabel.TabIndex = 17;
            this.InQueueLabel.Text = "0";
            // 
            // backgroundWorkerForSync
            // 
            this.backgroundWorkerForSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForSync_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Syncing Folder";
            // 
            // SyncingFolder
            // 
            this.SyncingFolder.AutoSize = true;
            this.SyncingFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingFolder.Location = new System.Drawing.Point(167, 346);
            this.SyncingFolder.Name = "SyncingFolder";
            this.SyncingFolder.Size = new System.Drawing.Size(60, 28);
            this.SyncingFolder.TabIndex = 19;
            this.SyncingFolder.Text = "None";
            // 
            // SyncingAccountLabel
            // 
            this.SyncingAccountLabel.AutoSize = true;
            this.SyncingAccountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingAccountLabel.Location = new System.Drawing.Point(167, 386);
            this.SyncingAccountLabel.Name = "SyncingAccountLabel";
            this.SyncingAccountLabel.Size = new System.Drawing.Size(60, 28);
            this.SyncingAccountLabel.TabIndex = 21;
            this.SyncingAccountLabel.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Syncing Account";
            // 
            // SyncingRemotePathLabel
            // 
            this.SyncingRemotePathLabel.AutoSize = true;
            this.SyncingRemotePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingRemotePathLabel.Location = new System.Drawing.Point(167, 426);
            this.SyncingRemotePathLabel.Name = "SyncingRemotePathLabel";
            this.SyncingRemotePathLabel.Size = new System.Drawing.Size(60, 28);
            this.SyncingRemotePathLabel.TabIndex = 23;
            this.SyncingRemotePathLabel.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Syncing Remote Path";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(351, 549);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LastSyncRemotePath
            // 
            this.LastSyncRemotePath.AutoSize = true;
            this.LastSyncRemotePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSyncRemotePath.Location = new System.Drawing.Point(167, 291);
            this.LastSyncRemotePath.Name = "LastSyncRemotePath";
            this.LastSyncRemotePath.Size = new System.Drawing.Size(60, 28);
            this.LastSyncRemotePath.TabIndex = 30;
            this.LastSyncRemotePath.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Last Sync Remote Path";
            // 
            // LastSyncAccountLabel
            // 
            this.LastSyncAccountLabel.AutoSize = true;
            this.LastSyncAccountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSyncAccountLabel.Location = new System.Drawing.Point(167, 251);
            this.LastSyncAccountLabel.Name = "LastSyncAccountLabel";
            this.LastSyncAccountLabel.Size = new System.Drawing.Size(60, 28);
            this.LastSyncAccountLabel.TabIndex = 28;
            this.LastSyncAccountLabel.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Last Sync Account";
            // 
            // LastSyncFolderLabel
            // 
            this.LastSyncFolderLabel.AutoSize = true;
            this.LastSyncFolderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSyncFolderLabel.Location = new System.Drawing.Point(167, 211);
            this.LastSyncFolderLabel.Name = "LastSyncFolderLabel";
            this.LastSyncFolderLabel.Size = new System.Drawing.Size(60, 28);
            this.LastSyncFolderLabel.TabIndex = 26;
            this.LastSyncFolderLabel.Text = "None";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Last Sync Folder";
            // 
            // ErrorCountButton
            // 
            this.ErrorCountButton.Location = new System.Drawing.Point(499, 47);
            this.ErrorCountButton.Name = "ErrorCountButton";
            this.ErrorCountButton.Size = new System.Drawing.Size(275, 47);
            this.ErrorCountButton.TabIndex = 31;
            this.ErrorCountButton.Text = "Error Occurred Today ( 0 )";
            this.ErrorCountButton.UseVisualStyleBackColor = true;
            this.ErrorCountButton.Click += new System.EventHandler(this.ErrorCountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 607);
            this.Controls.Add(this.ErrorCountButton);
            this.Controls.Add(this.LastSyncRemotePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastSyncAccountLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LastSyncFolderLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SyncingRemotePathLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SyncingAccountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SyncingFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InQueueLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NextSyncLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastSyncedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SyncStatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartSyncButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Home - DriveSyncDesktop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerForHttp;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Button SettingsButton;
        private Button StartSyncButton;
        private Label label1;
        private Label SyncStatusLabel;
        private Label label3;
        private Label LastSyncedLabel;
        private Label label5;
        private Label NextSyncLabel;
        private Label label7;
        private Label InQueueLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForSync;
        private Label label2;
        private Label SyncingFolder;
        private Label SyncingAccountLabel;
        private Label label6;
        private Label SyncingRemotePathLabel;
        private Label label9;
        private Button CancelButton;
        private Label LastSyncRemotePath;
        private Label label8;
        private Label LastSyncAccountLabel;
        private Label label11;
        private Label LastSyncFolderLabel;
        private Label label13;
        private Button ErrorCountButton;
    }
}