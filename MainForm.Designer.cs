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
            soundSelectDialog = new OpenFileDialog();
            soundDropBox = new PictureBox();
            startButton = new Button();
            selectedSoundsLabel = new Label();
            selectedSoundsPanel = new Panel();
            birdNameLabel = new Label();
            fileNameLabel = new Label();
            startConditionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)soundDropBox).BeginInit();
            selectedSoundsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selectionCommandLabel
            // 
            selectionCommandLabel.Anchor = AnchorStyles.Top;
            selectionCommandLabel.AutoSize = true;
            selectionCommandLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectionCommandLabel.Location = new Point(77, 25);
            selectionCommandLabel.Name = "selectionCommandLabel";
            selectionCommandLabel.Size = new Size(643, 47);
            selectionCommandLabel.TabIndex = 0;
            selectionCommandLabel.Text = "Drop Sound Files Below or Click the +";
            // 
            // soundSelectDialog
            // 
            soundSelectDialog.Filter = "Audio Files|*.mp3;*.flac;*.aac;*.adt;*.adts;*.m4a;*.wav;*.wma;*.ac3;*.3gp;*.3g2;*.amr;*.mka;*.oga;*.ogg;*.opus";
            soundSelectDialog.Multiselect = true;
            // 
            // soundDropBox
            // 
            soundDropBox.AllowDrop = true;
            soundDropBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            soundDropBox.BackColor = SystemColors.Control;
            soundDropBox.BackgroundImage = Properties.Resources.lil_plus;
            soundDropBox.BackgroundImageLayout = ImageLayout.Center;
            soundDropBox.BorderStyle = BorderStyle.Fixed3D;
            soundDropBox.Cursor = Cursors.Hand;
            soundDropBox.Location = new Point(97, 93);
            soundDropBox.Name = "soundDropBox";
            soundDropBox.Size = new Size(598, 100);
            soundDropBox.TabIndex = 1;
            soundDropBox.TabStop = false;
            soundDropBox.Click += DropBox_OnClick;
            soundDropBox.DragDrop += DropBox_OnDragDrop;
            soundDropBox.DragEnter += DropBox_OnDragEnter;
            soundDropBox.DragLeave += DropBox_OnMouseLeave;
            soundDropBox.MouseLeave += DropBox_OnMouseLeave;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom;
            startButton.Enabled = false;
            startButton.Location = new Point(335, 483);
            startButton.Name = "startButton";
            startButton.Size = new Size(135, 45);
            startButton.TabIndex = 2;
            startButton.Text = "Begin Study Sesh";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += BeginStudySesh_OnClick;
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
            selectedSoundsPanel.Size = new Size(598, 247);
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
            // startConditionLabel
            // 
            startConditionLabel.Anchor = AnchorStyles.Bottom;
            startConditionLabel.AutoSize = true;
            startConditionLabel.Location = new Point(237, 547);
            startConditionLabel.Name = "startConditionLabel";
            startConditionLabel.Size = new Size(331, 15);
            startConditionLabel.TabIndex = 7;
            startConditionLabel.Text = "(All bird names must be filled in before beginning study sesh)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(784, 571);
            Controls.Add(startConditionLabel);
            Controls.Add(selectedSoundsPanel);
            Controls.Add(selectedSoundsLabel);
            Controls.Add(startButton);
            Controls.Add(soundDropBox);
            Controls.Add(selectionCommandLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "Bird Sound Randomizer Lite";
            Click += DropBox_OnClick;
            ((System.ComponentModel.ISupportInitialize)soundDropBox).EndInit();
            selectedSoundsPanel.ResumeLayout(false);
            selectedSoundsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectionCommandLabel;
        private OpenFileDialog soundSelectDialog;
        private PictureBox soundDropBox;
        private Button startButton;
        private Label selectedSoundsLabel;
        private Panel selectedSoundsPanel;
        private Label birdNameLabel;
        private Label fileNameLabel;
        private Label startConditionLabel;
    }
}
