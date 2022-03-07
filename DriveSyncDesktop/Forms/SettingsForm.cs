using DriveSyncDesktop.ApiModels;
using DriveSyncDesktop.Service;

namespace DriveSyncDesktop.Forms;

public partial class SettingsForm : Form
{
    private static RCloneApiService _rCloneApiService;
    private string? _selectedRemoteForDelete;

    public SettingsForm()
    {
        InitializeComponent();
        _rCloneApiService = new RCloneApiService("http://localhost:5572");
    }

    // ----- GridView -----
    private async Task PopulateGridView()
    {
        toolStripStatusLabel.Text = "Loading remotes";

        // Data grid view
        var data = await _rCloneApiService.GetRemotes();
        if (dataGridView.CurrentRow != null) dataGridView.CurrentRow.Selected = false;
        dataGridView.DataSource = data?.Remotes.Select((x, index) => new
        {
            No = ++index,
            Name = x
        }).ToList();

        toolStripStatusLabel.Text = "Successfully loaded remotes";
    }

    // ----- Form Events -----
    private async void SettingsForm_Load(object sender, EventArgs e)
    {
        // Disable delete button
        DeleteAccountButton.Enabled = false;

        try
        {
            await PopulateGridView();
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

            await PopulateGridView();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}