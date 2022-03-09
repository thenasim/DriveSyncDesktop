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
            this.SyncingAccount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SyncingRemotePath = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
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
            this.StartSyncButton.Location = new System.Drawing.Point(320, 394);
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
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last synced";
            // 
            // LastSyncedLabel
            // 
            this.LastSyncedLabel.AutoSize = true;
            this.LastSyncedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSyncedLabel.Location = new System.Drawing.Point(119, 69);
            this.LastSyncedLabel.Name = "LastSyncedLabel";
            this.LastSyncedLabel.Size = new System.Drawing.Size(95, 28);
            this.LastSyncedLabel.TabIndex = 13;
            this.LastSyncedLabel.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next sync";
            // 
            // NextSyncLabel
            // 
            this.NextSyncLabel.AutoSize = true;
            this.NextSyncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextSyncLabel.Location = new System.Drawing.Point(119, 113);
            this.NextSyncLabel.Name = "NextSyncLabel";
            this.NextSyncLabel.Size = new System.Drawing.Size(95, 28);
            this.NextSyncLabel.TabIndex = 15;
            this.NextSyncLabel.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "In queue";
            // 
            // InQueueLabel
            // 
            this.InQueueLabel.AutoSize = true;
            this.InQueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InQueueLabel.Location = new System.Drawing.Point(119, 157);
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
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Syncing Folder";
            // 
            // SyncingFolder
            // 
            this.SyncingFolder.AutoSize = true;
            this.SyncingFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingFolder.Location = new System.Drawing.Point(167, 225);
            this.SyncingFolder.Name = "SyncingFolder";
            this.SyncingFolder.Size = new System.Drawing.Size(60, 28);
            this.SyncingFolder.TabIndex = 19;
            this.SyncingFolder.Text = "None";
            // 
            // SyncingAccount
            // 
            this.SyncingAccount.AutoSize = true;
            this.SyncingAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingAccount.Location = new System.Drawing.Point(167, 265);
            this.SyncingAccount.Name = "SyncingAccount";
            this.SyncingAccount.Size = new System.Drawing.Size(60, 28);
            this.SyncingAccount.TabIndex = 21;
            this.SyncingAccount.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Syncing Account";
            // 
            // SyncingRemotePath
            // 
            this.SyncingRemotePath.AutoSize = true;
            this.SyncingRemotePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncingRemotePath.Location = new System.Drawing.Point(167, 305);
            this.SyncingRemotePath.Name = "SyncingRemotePath";
            this.SyncingRemotePath.Size = new System.Drawing.Size(60, 28);
            this.SyncingRemotePath.TabIndex = 23;
            this.SyncingRemotePath.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Syncing Remote Path";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(350, 458);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 528);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SyncingRemotePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SyncingAccount);
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
        private Label SyncingAccount;
        private Label label6;
        private Label SyncingRemotePath;
        private Label label9;
        private Button CancelButton;
    }
}