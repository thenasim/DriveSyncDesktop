namespace DriveSyncDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var currentDirectory = Application.StartupPath;

            var binary = Path.Join(currentDirectory, "Binary");

            MessageBox.Show(binary);

        }
    }
}