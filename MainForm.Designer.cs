namespace BirdSoundRandomizerLite
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            selectionCommandLabel = new Label();
            mp3SelectDialog = new OpenFileDialog();
            mp3DropBox = new PictureBox();
            startButton = new Button();
            selectedSoundsLabel = new Label();
            selectedSoundsPanel = new Panel();
            birdNameLabel = new Label();
            fileNameLabel = new Label();
            testBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)mp3DropBox).BeginInit();
            selectedSoundsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selectionCommandLabel
            // 
            selectionCommandLabel.Anchor = AnchorStyles.Top;
            selectionCommandLabel.AutoSize = true;
            selectionCommandLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectionCommandLabel.Location = new Point(80, 28);
            selectionCommandLabel.Name = "selectionCommandLabel";
            selectionCommandLabel.Size = new Size(640, 47);
            selectionCommandLabel.TabIndex = 0;
            selectionCommandLabel.Text = "Drop MP3 Files Below or Click the (+)";
            // 
            // mp3SelectDialog
            // 
            mp3SelectDialog.Filter = "MP3 Files|*.mp3";
            // 
            // mp3DropBox
            // 
            mp3DropBox.AllowDrop = true;
            mp3DropBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mp3DropBox.BackColor = SystemColors.Control;
            mp3DropBox.BackgroundImage = Properties.Resources.lil_plus;
            mp3DropBox.BackgroundImageLayout = ImageLayout.Center;
            mp3DropBox.BorderStyle = BorderStyle.Fixed3D;
            mp3DropBox.Cursor = Cursors.Hand;
            mp3DropBox.Location = new Point(97, 93);
            mp3DropBox.Name = "mp3DropBox";
            mp3DropBox.Size = new Size(598, 100);
            mp3DropBox.TabIndex = 1;
            mp3DropBox.TabStop = false;
            mp3DropBox.DragEnter += DropBox_OnDragEnter;
            mp3DropBox.DragLeave += DropBox_OnMouseLeave;
            mp3DropBox.MouseLeave += DropBox_OnMouseLeave;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom;
            startButton.Enabled = false;
            startButton.Location = new Point(335, 504);
            startButton.Name = "startButton";
            startButton.Size = new Size(135, 45);
            startButton.TabIndex = 2;
            startButton.Text = "Begin Study Sesh";
            startButton.UseVisualStyleBackColor = true;
            // 
            // selectedSoundsLabel
            // 
            selectedSoundsLabel.Anchor = AnchorStyles.Top;
            selectedSoundsLabel.AutoSize = true;
            selectedSoundsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedSoundsLabel.Location = new Point(335, 207);
            selectedSoundsLabel.Name = "selectedSoundsLabel";
            selectedSoundsLabel.Size = new Size(122, 20);
            selectedSoundsLabel.TabIndex = 4;
            selectedSoundsLabel.Text = "Selected Sounds";
            // 
            // selectedSoundsPanel
            // 
            selectedSoundsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedSoundsPanel.AutoScroll = true;
            selectedSoundsPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedSoundsPanel.Controls.Add(birdNameLabel);
            selectedSoundsPanel.Controls.Add(fileNameLabel);
            selectedSoundsPanel.Location = new Point(97, 230);
            selectedSoundsPanel.Name = "selectedSoundsPanel";
            selectedSoundsPanel.Size = new Size(598, 268);
            selectedSoundsPanel.TabIndex = 6;
            // 
            // birdNameLabel
            // 
            birdNameLabel.Anchor = AnchorStyles.Top;
            birdNameLabel.AutoSize = true;
            birdNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            birdNameLabel.Location = new Point(260, 13);
            birdNameLabel.Name = "birdNameLabel";
            birdNameLabel.Size = new Size(84, 20);
            birdNameLabel.TabIndex = 8;
            birdNameLabel.Text = "Bird Name";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            fileNameLabel.Location = new Point(58, 13);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(79, 20);
            fileNameLabel.TabIndex = 7;
            fileNameLabel.Text = "File Name";
            // 
            // testBtn
            // 
            testBtn.Location = new Point(699, 199);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(75, 23);
            testBtn.TabIndex = 7;
            testBtn.Text = "test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += Test;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(784, 561);
            Controls.Add(testBtn);
            Controls.Add(selectedSoundsPanel);
            Controls.Add(selectedSoundsLabel);
            Controls.Add(startButton);
            Controls.Add(mp3DropBox);
            Controls.Add(selectionCommandLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "Bird Sound Randomizer Lite";
            ((System.ComponentModel.ISupportInitialize)mp3DropBox).EndInit();
            selectedSoundsPanel.ResumeLayout(false);
            selectedSoundsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectionCommandLabel;
        private OpenFileDialog mp3SelectDialog;
        private PictureBox mp3DropBox;
        private Button startButton;
        private Label selectedSoundsLabel;
        private Panel selectedSoundsPanel;
        private Label birdNameLabel;
        private Label fileNameLabel;
        private Button testBtn;
    }
}
