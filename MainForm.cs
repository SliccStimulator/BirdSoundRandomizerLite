using BirdSoundRandomizerLite.Properties;
using System.Diagnostics;
using WMPLib;

namespace BirdSoundRandomizerLite
{
    public partial class MainForm : Form
    {
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
            if (sender != mp3DropBox)
            {
                return;
            }
        }

        private void Test(object sender, EventArgs e)
        {
            AddSound(@"D:\Documents\Special_Sounds\ben's evil sounds.mp3");
        }

        /**
         * Sets up form controls and data stuff for a new sound
         * file when it gets added or whatever
         */
        private void AddSound(string filePath)
        {
            var currDataEntry = new SoundEntry(filePath, new Control[4]);

            int currRowY = 43 + (40 * DataManager.SelectedSounds.Count);

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
            };

            var playSoundButton = new Button
            {
                Width = 23,
                Height = 23,
                Location = new Point(selectedSoundsPanel.Width - 160, currRowY),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackgroundImage = Resources.speaker_icon,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            playSoundButton.Click += (sender, e) =>
            {
                var player = new WindowsMediaPlayer();
                player.URL = filePath;
                player.controls.play();
            };

            var deleteButton = new Button
            {
                Width = 23,
                Height = 23,
                Location = new Point(selectedSoundsPanel.Width - 60, currRowY),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Text = "X",
                Font = new Font(Font, FontStyle.Bold),
                ForeColor = Color.Red
            };

            // TODO implement deletion functionality

            // add controls to data object
            currDataEntry.AssociatedControls = [fileNameLbl, birdNameTxtBox, playSoundButton, deleteButton];

            // append controls to panel
            selectedSoundsPanel.Controls.AddRange(currDataEntry.AssociatedControls);

            // add data entry to global list
            DataManager.SelectedSounds.Add(currDataEntry);
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
    }
}