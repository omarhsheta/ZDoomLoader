namespace ZDoomLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void engine_button_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "EXE Files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    var fileName = filePath.Split("\\");
                    string[] supportedEngines = ["gzdoom.exe", "zdoom.exe", "zandronum.exe", "qzandronum.exe"];
                    if (!supportedEngines.Contains(fileName[fileName.Length-1])) {
                        MessageBox.Show("Please choose either GZDoom, ZDoom, or Zandronum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        engine_input.Text = filePath;
                    }
                }
            }


        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if (engine_input.Text.Length > 0 )
            {
                System.Diagnostics.Process.Start(engine_input.Text);
                this.Close();
            } else
            {
                MessageBox.Show("Please load a supported Doom Engine", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
