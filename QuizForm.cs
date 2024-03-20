using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BirdSoundRandomizerLite
{
    public partial class QuizForm : Form
    {
        private readonly Random Randomizer = new Random();
        private readonly WindowsMediaPlayer soundPlayer = new WindowsMediaPlayer();

        private List<SoundEntry> ShuffledEntries = new List<SoundEntry>();
        private int NextSoundIndex = 0;

        private string CurrentFilePath {  get; set; }

        public QuizForm()
        {
            CurrentFilePath = "";
            ShuffledEntries.AddRange(DataManager.SelectedSounds);

            InitializeComponent();
            ShuffleEntries();
            LoadNextSound();
        }

        private void ShuffleEntries()
        {
            int currIndex = ShuffledEntries.Count;

            while (currIndex > 1)
            {
                currIndex--;

                int randomTarget = Randomizer.Next(currIndex + 1);

                SoundEntry temp = ShuffledEntries[randomTarget];
                ShuffledEntries[randomTarget] = ShuffledEntries[currIndex];
                ShuffledEntries[currIndex] = temp;
            }
        }

        private void LoadNextSound()
        {
            SoundEntry nextEntry = ShuffledEntries[NextSoundIndex];

            NextSoundIndex = (NextSoundIndex + 1) % ShuffledEntries.Count;

            if (NextSoundIndex == 0)
            {
                ShuffleEntries();
            }

            // open sound file in player and play
            CurrentFilePath = nextEntry.FilePath;
            soundPlayer.URL = nextEntry.FilePath;
            soundPlayer.controls.play();

            // change bird label text and center
            birdNameLbl.Text = nextEntry.Name;
            birdNameLbl.Location = new Point((this.Width) / 2 - (birdNameLbl.Width / 2), birdNameLbl.Location.Y);
        }

        // EVENT HANDLERS

        private void PlaySound_OnClick(object sender, EventArgs e)
        {
            soundPlayer.URL = CurrentFilePath;
            soundPlayer.controls.play();
        }

        private void RevealLabel_OnClick(object sender, EventArgs e)
        {
            // alter visibility of relavent labels
            clickToRevealLbl1.Visible = false;
            clickToRevealLbl2.Visible = false;
            birdNameLbl.Visible = true;

            // enable next button
            nextButton.Enabled = true;
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            // revert visibility of labels to default
            birdNameLbl.Visible = false;
            clickToRevealLbl1.Visible = true;
            clickToRevealLbl2.Visible = true;

            // disable next button
            nextButton.Enabled = false;

            // load new random sound
            LoadNextSound();
        }
    }
}
