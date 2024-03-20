using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private string CurrentFilePath {  get; set; }

        public QuizForm()
        {
            CurrentFilePath = "";

            InitializeComponent();
            LoadRandomSound();
        }

        private void LoadRandomSound()
        {
            SoundEntry randomEntry = DataManager.SelectedSounds[Randomizer.Next(DataManager.SelectedSounds.Count)];

            // open sound file in player and play
            CurrentFilePath = randomEntry.FilePath;
            soundPlayer.URL = randomEntry.FilePath;
            soundPlayer.controls.play();

            // change bird label text and center
            birdNameLbl.Text = randomEntry.Name;
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
            LoadRandomSound();
        }
    }
}
