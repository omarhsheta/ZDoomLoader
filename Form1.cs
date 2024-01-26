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
                    if (!supportedEngines.Contains(fileName[fileName.Length - 1]))
                    {
                        MessageBox.Show("Please choose either GZDoom, ZDoom, or Zandronum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        engine_input.Text = filePath;
                    }
                }
            }


        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if (engine_input.Text.Length > 0)
            {
                if (pwad_list.Items.Count > 0)
                {
                    var args = "";
                    foreach (var item in pwad_list.CheckedItems)
                    {
                        args += item.ToString() + ' ';
                    }
                    System.Diagnostics.Process.Start(engine_input.Text, args);
                } else
                {
                    System.Diagnostics.Process.Start(engine_input.Text);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please load a supported Doom Engine", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pwad_button_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PWAD Files (*.wad)|*.wad";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    var fileName = filePath.Split("\\");
                    string[] iwadFiles = ["doom.wad", "doom2.wad", "plutonia.wad", "tnt.wad"];
                    if (iwadFiles.Contains(fileName[fileName.Length - 1].ToLower()))
                    {
                        MessageBox.Show("You cannot choose an IWAD, such as Doom 1, Doom 2, ...etc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pwad_list.Items.Add(filePath);
                    }
                }
            }
        }
    }
}
