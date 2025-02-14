namespace MusicPlayerApp
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            MPALogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            lblFooter = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.LightBlue;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(MPALogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 40);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(757, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MPALogo
            // 
            MPALogo.AutoSize = true;
            MPALogo.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MPALogo.Location = new Point(20, 10);
            MPALogo.Name = "MPALogo";
            MPALogo.Size = new Size(79, 20);
            MPALogo.TabIndex = 0;
            MPALogo.Text = "MPA Logo";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 17;
            listBoxSongs.Location = new Point(559, 60);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.SelectionMode = SelectionMode.MultiExtended;
            listBoxSongs.Size = new Size(220, 242);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.BackColor = Color.DarkBlue;
            btnSelectSongs.FlatStyle = FlatStyle.Flat;
            btnSelectSongs.ForeColor = SystemColors.Control;
            btnSelectSongs.Location = new Point(559, 323);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(118, 54);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Select Songs";
            btnSelectSongs.UseVisualStyleBackColor = false;
            btnSelectSongs.Click += btnSelectSongs_Click;
            // 
            // axWindowsMediaPlayerMusic
            // 
            axWindowsMediaPlayerMusic.Enabled = true;
            axWindowsMediaPlayerMusic.Location = new Point(12, 60);
            axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            axWindowsMediaPlayerMusic.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayerMusic.OcxState");
            axWindowsMediaPlayerMusic.Size = new Size(534, 353);
            axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.ForeColor = SystemColors.ControlDark;
            lblFooter.Location = new Point(320, 445);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(125, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Developped By: Resley";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOliveGreen;
            btnSave.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(683, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 54);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(683, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lblFooter);
            Controls.Add(axWindowsMediaPlayerMusic);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private PictureBox pictureBox1;
        private Label MPALogo;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private Label lblFooter;
        private Button btnSave;
        private Button btnDelete;
    }
}
