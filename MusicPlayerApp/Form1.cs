using Newtonsoft.Json;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
            LoadSongs(); // Load saved songs when the app starts
        }

        string[] paths, files; //Create global variables of String Array to save the title, names of the tracks
        private const string SaveFile = "savedSongs.json"; // JSON file to store song paths

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Song selection
            OpenFileDialog ofd = new OpenFileDialog();
            //Select mutiples files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array

                //Display the music titles in lisbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display songs in listbox
                }
            }
        }

        private void LoadSongs()
        {
            if (File.Exists(SaveFile))
            {
                paths = JsonConvert.DeserializeObject<string[]>(File.ReadAllText(SaveFile));
                if (paths != null)
                {
                    files = new string[paths.Length];
                    for (int i = 0; i < paths.Length; i++)
                    {
                        files[i] = Path.GetFileName(paths[i]); // Extract file names
                    }

                    listBoxSongs.Items.Clear();
                    listBoxSongs.Items.AddRange(files);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Play music
            if (listBoxSongs.SelectedIndex >= 0)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (paths != null && paths.Length >= 0)
            {
                File.WriteAllText(SaveFile, JsonConvert.SerializeObject(paths));
                MessageBox.Show("Songs saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No songs to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndices.Count > 0)
            {
                // Get selected indices in descending order
                List<int> selectedIndices = listBoxSongs.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();

                // Convert paths array to List for easier removal
                List<string> pathList = paths.ToList();

                // Remove selected items
                foreach (int index in selectedIndices)
                {
                    listBoxSongs.Items.RemoveAt(index);
                    pathList.RemoveAt(index);
                }

                // Update paths array and save to JSON
                paths = pathList.ToArray();
                File.WriteAllText(SaveFile, JsonConvert.SerializeObject(paths));

                // Stop music if the list is empty
                if (listBoxSongs.Items.Count == 0)
                {
                    axWindowsMediaPlayerMusic.Ctlcontrols.stop();
                    axWindowsMediaPlayerMusic.URL = ""; // Clear the player
                }

                MessageBox.Show("Selected songs deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least one song to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
