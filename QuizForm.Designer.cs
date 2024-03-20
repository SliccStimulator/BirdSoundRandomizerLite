namespace BirdSoundRandomizerLite
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            playSoundButton = new Button();
            clickToRevealLbl1 = new Label();
            clickToRevealLbl2 = new Label();
            birdNameLbl = new Label();
            nextButton = new Button();
            SuspendLayout();
            // 
            // playSoundButton
            // 
            playSoundButton.AutoSize = true;
            playSoundButton.BackgroundImage = Properties.Resources.speaker_icon;
            playSoundButton.BackgroundImageLayout = ImageLayout.Stretch;
            playSoundButton.Location = new Point(225, 33);
            playSoundButton.Name = "playSoundButton";
            playSoundButton.Size = new Size(125, 125);
            playSoundButton.TabIndex = 0;
            playSoundButton.UseVisualStyleBackColor = true;
            playSoundButton.Click += PlaySound_OnClick;
            // 
            // clickToRevealLbl1
            // 
            clickToRevealLbl1.AutoSize = true;
            clickToRevealLbl1.BackColor = Color.Black;
            clickToRevealLbl1.Cursor = Cursors.Hand;
            clickToRevealLbl1.Font = new Font("Engravers MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickToRevealLbl1.ForeColor = Color.White;
            clickToRevealLbl1.Location = new Point(57, 250);
            clickToRevealLbl1.Name = "clickToRevealLbl1";
            clickToRevealLbl1.Size = new Size(447, 41);
            clickToRevealLbl1.TabIndex = 1;
            clickToRevealLbl1.Text = "CLICK TO REVEAL";
            clickToRevealLbl1.Click += RevealLabel_OnClick;
            // 
            // clickToRevealLbl2
            // 
            clickToRevealLbl2.AutoSize = true;
            clickToRevealLbl2.BackColor = Color.Black;
            clickToRevealLbl2.Cursor = Cursors.Hand;
            clickToRevealLbl2.Font = new Font("Engravers MT", 26.25F, FontStyle.Bold);
            clickToRevealLbl2.ForeColor = Color.White;
            clickToRevealLbl2.Location = new Point(134, 291);
            clickToRevealLbl2.Name = "clickToRevealLbl2";
            clickToRevealLbl2.Size = new Size(291, 41);
            clickToRevealLbl2.TabIndex = 2;
            clickToRevealLbl2.Text = "BIRD NAME";
            clickToRevealLbl2.Click += RevealLabel_OnClick;
            // 
            // birdNameLbl
            // 
            birdNameLbl.AutoSize = true;
            birdNameLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birdNameLbl.ForeColor = SystemColors.ControlText;
            birdNameLbl.Location = new Point(246, 278);
            birdNameLbl.Name = "birdNameLbl";
            birdNameLbl.Size = new Size(68, 30);
            birdNameLbl.TabIndex = 3;
            birdNameLbl.Text = "label1";
            birdNameLbl.Visible = false;
            // 
            // nextButton
            // 
            nextButton.Enabled = false;
            nextButton.Location = new Point(247, 446);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(91, 37);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next Bird >";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_OnClick;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 521);
            Controls.Add(nextButton);
            Controls.Add(birdNameLbl);
            Controls.Add(clickToRevealLbl2);
            Controls.Add(clickToRevealLbl1);
            Controls.Add(playSoundButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(580, 560);
            MinimizeBox = false;
            MinimumSize = new Size(580, 560);
            Name = "QuizForm";
            Text = "Bird Quiz!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playSoundButton;
        private Label clickToRevealLbl1;
        private Label clickToRevealLbl2;
        private Label birdNameLbl;
        private Button nextButton;
    }
}