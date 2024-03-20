using BirdSoundRandomizerLite.Properties;
using System.Diagnostics;
using WMPLib;

namespace BirdSoundRandomizerLite
{
    public partial class MainForm : Form
    {
        private static readonly string[] SupportedFileExtensions = [".mp3", ".flac", ".aac",
                                                                    ".adt", ".adts", ".m4a",
                                                                    ".wav", ".wma", ".ac3",
                                                                    ".3gp", ".3g2", ".amr",
                                                                    ".mka", ".oga", ".ogg", ".opus"];

        private readonly WindowsMediaPlayer SoundPlayer = new WindowsMediaPlayer();

        public MainForm()
        {
            InitializeComponent();
        }

        // EVENT HANDLERS

        private void DropBox_OnDragEnter(object sender, DragEventArgs e)
        {
            if (sender is not PictureBox)
            {
                return;
            }

            var dropBox = (PictureBox)sender;

            dropBox.BackColor = SystemColors.ControlDark;

            // ensure all files being dropped are audio files
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void DropBox_OnDragDrop(object sender, DragEventArgs e)
        {
            if (sender is not PictureBox)
            {
                return;
            }

            var dropBox = (PictureBox)sender;

            // revert dropbox color
            dropBox.BackColor = SystemColors.Control;

            // attempt to get file names
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var data = e.Data.GetData(DataFormats.FileDrop);

                string[] fileNames = data == null ? [] : (string[])data;

                // iterate over file names
                var invalidFiles = new List<string>();

                foreach (string currFileName in fileNames)
                {
                    if (FileTypeSupported(currFileName))
                    {
                        // add valid sounds
                        AddSound(currFileName);
                    }
                    else
                    {
                        // record rejected files
                        invalidFiles.Add(currFileName);
                    }
                }

                // inform the user if any files could not be added
                if (invalidFiles.Count > 0)
                {
                    string notificationMessage = "The following files could not be added because they are not valid sound files:";

                    foreach (string currFileName in invalidFiles)
                    {
                        notificationMessage += "\n- " + ShortName(currFileName);
                    }

                    MessageBox.Show(notificationMessage, "Invalid File Types Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DropBox_OnMouseLeave(object sender, EventArgs e)
        {
            if (sender is not PictureBox)
            {
                return;
            }

            ((PictureBox)sender).BackColor = SystemColors.Control;
        }

        private void DropBox_OnClick(object sender, EventArgs e)
        {
            if (sender != soundDropBox)
            {
                return;
            }

            // show file dialog and check result
            if (soundSelectDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string currFileName in soundSelectDialog.FileNames)
                {
                    AddSound(currFileName);
                }
            }
        }

        private void BeginStudySesh_OnClick(object sender, EventArgs e)
        {
            var quizForm = new QuizForm();

            quizForm.ShowDialog();
        }

        /**
         * Sets up form controls and data stuff for a new sound
         * file when it gets added or whatever
         */
        private void AddSound(string filePath)
        {
            var currDataEntry = new SoundEntry(filePath, new Control[4]);

            int currRowY = fileNameLabel.Location.Y + 30 + (40 * DataManager.SelectedSounds.Count);

            // create controls
            var fileNameLbl = new Label
            {
                Text = ShortName(filePath),
                Width = 5 * Text.Length + 15,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            fileNameLbl.Location = new Point(fileNameLabel.Location.X + (fileNameLabel.Width / 2) - (fileNameLbl.Width / 2), currRowY);

            var birdNameTxtBox = new TextBox
            {
                Width = 170,
                Location = new Point(birdNameLabel.Location.X + (birdNameLabel.Width / 2) - 85, currRowY),
                Anchor = AnchorStyles.Top
            };

            birdNameTxtBox.KeyUp += (sender, e) =>
            {
                currDataEntry.Name = birdNameTxtBox.Text;
                CheckNameFields();
            };

            var playSoundButton = new Button
            {
                Width = 23,
                Height = 23,
                Location = new Point(selectedSoundsPanel.Width - (selectedSoundsPanel.VerticalScroll.Visible ? 177 : 160), currRowY),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackgroundImage = Resources.speaker_icon,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            playSoundButton.Click += (sender, e) =>
            {
                SoundPlayer.URL = filePath;
                SoundPlayer.controls.play();
            };

            var deleteButton = new Button
            {
                Width = 23,
                Height = 23,
                Location = new Point(selectedSoundsPanel.Width - (selectedSoundsPanel.VerticalScroll.Visible ? 77 : 60), currRowY),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Text = "X",
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.Red
            };

            deleteButton.Click += (sender, e) =>
            {
                // remove controls from form
                foreach (Control currControl in currDataEntry.AssociatedControls)
                {
                    selectedSoundsPanel.Controls.Remove(currControl);
                }

                // adjust Y position of controls below deleted ones
                int deletionIndex = DataManager.SelectedSounds.IndexOf(currDataEntry);

                if (deletionIndex >= 0)
                {
                    DataManager.SelectedSounds.RemoveAt(deletionIndex);

                    for (int i = deletionIndex; i < DataManager.SelectedSounds.Count; i++)
                    {
                        foreach (Control currControl in DataManager.SelectedSounds[i].AssociatedControls)
                        {
                            currControl.Location = new Point(currControl.Location.X, currControl.Location.Y - 40);
                        }
                    }
                }

                // check whether or not all name fields are filled
                CheckNameFields();
            };

            // add controls to data object
            currDataEntry.AssociatedControls = [fileNameLbl, birdNameTxtBox, playSoundButton, deleteButton];

            // append controls to panel
            selectedSoundsPanel.Controls.AddRange(currDataEntry.AssociatedControls);

            // add data entry to global list
            DataManager.SelectedSounds.Add(currDataEntry);
        }

        /**
         * Checks whether or not all name fields are filled, and if they
         * are, enable the start button
         */
        private void CheckNameFields()
        {
            // handle case wehere no sounds are selected
            if (DataManager.SelectedSounds.Count == 0)
            {
                startButton.Enabled = false;
                return;
            }

            // iterate over fields and make sure they're filled
            bool allFilled = true;

            foreach (SoundEntry currEntry in DataManager.SelectedSounds)
            {
                if (currEntry.AssociatedControls[1].Text.Trim() == "")
                {
                    allFilled = false;
                    break;
                }
            }

            startButton.Enabled = allFilled;
        }

        /**
         * Converts a file path into a short version of the file name,
         * no more than 25 characters in length
         */
        private static string ShortName(string fullPath)
        {
            string fileName = fullPath[(fullPath.LastIndexOf('\\') + 1)..];

            if (fileName.Length > 25)
            {
                fileName = fileName[..(fileName.Length - 9)] + "..." + fileName[(fileName.Length - 6)..];
            }

            return fileName;
        }

        /**
         * Determines whether or not the given filePath refers to a file
         * with a supported file type
         */
        private static bool FileTypeSupported(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();

            return SupportedFileExtensions.Contains(fileExtension);
        }
    }
}