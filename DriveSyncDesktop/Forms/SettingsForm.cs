﻿using System.Text.Json;
using DriveSyncDesktop.ApiModels;
using DriveSyncDesktop.Models;
using DriveSyncDesktop.Service;
using DriveSyncDesktop.Utils;

namespace DriveSyncDesktop.Forms;

public partial class SettingsForm : Form
{
    private static RCloneApiService _rCloneApiService;
    private readonly List<TextBoxCombobox> _textBoxComboboxList = new();
    private RemoteListsApiModel? _remoteLists;
    private string? _selectedRemoteForDelete;
    private AppConfigModel _appConfig = new();

    public SettingsForm()
    {
        InitializeComponent();
        _rCloneApiService = new RCloneApiService("http://localhost:5572");
    }

    // ----- Custom method -----
    private void LoadNewFolder(string? selectedFolderPath = null, string? selectedRemoteName = null)
    {
        FlowLayoutPanel flowPanel = new()
        {
            Width = 490,
            Height = 90,
            FlowDirection = FlowDirection.TopDown
        };
        var newFolderBrowserDialog = new FolderBrowserDialog();
        TextBox textBox = new()
        {
            Multiline = true,
            Font = new Font("Arial", 14),
            Size = new Size(470, 32),
            ReadOnly = true,
            Text = selectedFolderPath,
            PlaceholderText = "Click here to select folder",
        };
        ComboBox comboBox = new()
        {
            Font = new Font("Arial", 14),
            Size = new Size(190, 42),
            DropDownStyle = ComboBoxStyle.DropDownList
        };

        if (_remoteLists != null)
            foreach (var remoteName in _remoteLists.Remotes)
                comboBox.Items.Add(remoteName);

        comboBox.SelectedIndex = comboBox.FindString(selectedRemoteName);

        textBox.Click += (_, _) =>
        {
            if (newFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBox.Text = newFolderBrowserDialog.SelectedPath;
        };

        flowPanel.Controls.Add(textBox);
        flowPanel.Controls.Add(comboBox);

        flowLayoutPanel.Controls.Add(flowPanel);

        _textBoxComboboxList.Add(new TextBoxCombobox
        {
            TextBox = textBox,
            ComboBox = comboBox
        });
    }
    private void SetAppConfig(string removeTextBox = "")
    {
        var folderSyncList = new List<FolderToSync>();

        foreach (var x in _textBoxComboboxList.Where(x => removeTextBox != x.TextBox.Text))
        {
            if (string.IsNullOrEmpty(x.TextBox.Text) || string.IsNullOrEmpty(x.ComboBox.Text))
                continue;

            folderSyncList.Add(new FolderToSync
            {
                FolderPath = x.TextBox.Text,
                RemoteName = x.ComboBox.Text
            });
        }

        _appConfig = new AppConfigModel()
        {
            FolderToSyncList = folderSyncList,
            RepeatSync = Convert.ToDouble(DelayTimeTextbox.Text),
        };
    }
    private void SaveConfig(string removeTextBox = "")
    {
        SetAppConfig(removeTextBox);
        AppConfigUtils.Save(_appConfig);
    }

    // ----- GridView -----
    private async Task PopulateGridView(bool onlySelf = false)
    {
        toolStripStatusLabel.Text = "Loading remotes";
        toolStripProgressBar.Value = 50;

        // Data grid view
        _remoteLists = await _rCloneApiService.GetRemotes();
        if (dataGridView.CurrentRow != null) dataGridView.CurrentRow.Selected = false;
        dataGridView.DataSource = _remoteLists?.Remotes.Select((x, index) => new
        {
            No = ++index,
            Name = x
        }).ToList();

        toolStripStatusLabel.Text = "Successfully loaded remotes";

        if (onlySelf) toolStripProgressBar.Value = 100;
    }

    // ----- Form Events -----
    private async void SettingsForm_Load(object sender, EventArgs e)
    {
        // Disable delete button
        DeleteAccountButton.Enabled = false;

        try
        {
            AddNewButton.Enabled = false;

            toolStripProgressBar.Value = 20;

            StartUpCheckBox.Checked = StartupUtils.Get();

            toolStripProgressBar.Value = 50;

            var config = AppConfigUtils.Load();
            if (config != null)
            {
                DelayTimeTextbox.Text = config.RepeatSync.ToString();
            }

            await PopulateGridView();

            if (config?.FolderToSyncList != null)
                foreach (var toSync in config.FolderToSyncList)
                    LoadNewFolder(toSync.FolderPath, toSync.RemoteName);

            AddNewButton.Enabled = true;

            toolStripStatusLabel.Text = "Sucessfully loaded remotes and configs";
            toolStripProgressBar.Value = 100;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    // ----- Control Events -----
    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DeleteAccountButton.Enabled = true;

        var row = dataGridView.SelectedRows[0];
        _selectedRemoteForDelete = row?.Cells["Name"].Value.ToString();
    }

    private async void DeleteAccountButton_Click(object sender, EventArgs e)
    {
        try
        {
            var output = "";
            RCloneService.DeleteConfig(_selectedRemoteForDelete ?? "", ref output);

            await PopulateGridView(true);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (StartUpCheckBox.Checked)
                StartupUtils.Add();
            else
                StartupUtils.Remove();

            SaveConfig();

            MessageBox.Show("Saved successfully");
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void AddNewButton_Click(object sender, EventArgs e)
    {
        LoadNewFolder();
    }

    private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var row = dataGridView.SelectedRows[0];
        AccountNameTextbox.Text = row?.Cells["Name"].Value.ToString();
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        var configModel = new CreateConfigApiModel
        {
            Name = AccountNameTextbox.Text,
            Parameter = new ParameterApiModel()
            {
                RootFolderId = RootFolderIdTextbox.Text
            }
        };

        var output = "";
        RCloneService.CreateConfig(JsonSerializer.Serialize(configModel), ref output);
    }

    private async void RefreshButton_Click(object sender, EventArgs e)
    {
        await PopulateGridView(true);
    }
}

public class TextBoxCombobox
{
    public TextBox TextBox { get; set; }
    public ComboBox ComboBox { get; set; }
}