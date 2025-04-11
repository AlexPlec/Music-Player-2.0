namespace MusicPlayer
{
    partial class Form1
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
            btnPlay = new Button();
            lblStatus = new Label();
            lstSongs = new ListBox();
            btnPause = new Button();
            btnStop = new Button();
            picAlbumCover = new PictureBox();
            picArtist = new PictureBox();
            lblAlbum = new Label();
            lblArtist = new Label();
            lstArtists = new ListBox();
            lstAlbums = new ListBox();
            trkVolume = new TrackBar();
            chkLoopTrack = new CheckBox();
            chkLoopAlbum = new CheckBox();
            lblCurrentTime = new Label();
            lblTotalTime = new Label();
            trackBarTime = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)picAlbumCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picArtist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(67, 48);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(67, 203);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // lstSongs
            // 
            lstSongs.FormattingEnabled = true;
            lstSongs.ItemHeight = 15;
            lstSongs.Location = new Point(289, 250);
            lstSongs.Name = "lstSongs";
            lstSongs.Size = new Size(120, 94);
            lstSongs.TabIndex = 2;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(67, 82);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 3;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(67, 129);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // picAlbumCover
            // 
            picAlbumCover.Location = new Point(550, 102);
            picAlbumCover.Name = "picAlbumCover";
            picAlbumCover.Size = new Size(100, 50);
            picAlbumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            picAlbumCover.TabIndex = 6;
            picAlbumCover.TabStop = false;
            // 
            // picArtist
            // 
            picArtist.Location = new Point(550, 203);
            picArtist.Name = "picArtist";
            picArtist.Size = new Size(100, 50);
            picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
            picArtist.TabIndex = 7;
            picArtist.TabStop = false;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(568, 82);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(69, 15);
            lblAlbum.TabIndex = 8;
            lblAlbum.Text = "Album Title";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(568, 169);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(61, 15);
            lblArtist.TabIndex = 9;
            lblArtist.Text = "Artist Title";
            // 
            // lstArtists
            // 
            lstArtists.FormattingEnabled = true;
            lstArtists.ItemHeight = 15;
            lstArtists.Location = new Point(289, 12);
            lstArtists.Name = "lstArtists";
            lstArtists.Size = new Size(120, 94);
            lstArtists.TabIndex = 10;
            // 
            // lstAlbums
            // 
            lstAlbums.FormattingEnabled = true;
            lstAlbums.ItemHeight = 15;
            lstAlbums.Location = new Point(289, 124);
            lstAlbums.Name = "lstAlbums";
            lstAlbums.Size = new Size(120, 94);
            lstAlbums.TabIndex = 11;
            // 
            // trkVolume
            // 
            trkVolume.Location = new Point(545, 318);
            trkVolume.Maximum = 100;
            trkVolume.Name = "trkVolume";
            trkVolume.Size = new Size(104, 45);
            trkVolume.TabIndex = 12;
            trkVolume.TickStyle = TickStyle.None;
            trkVolume.Value = 100;
            // 
            // chkLoopTrack
            // 
            chkLoopTrack.AutoSize = true;
            chkLoopTrack.Location = new Point(487, 370);
            chkLoopTrack.Name = "chkLoopTrack";
            chkLoopTrack.Size = new Size(84, 19);
            chkLoopTrack.TabIndex = 13;
            chkLoopTrack.Text = "Loop Track";
            chkLoopTrack.UseVisualStyleBackColor = true;
            // 
            // chkLoopAlbum
            // 
            chkLoopAlbum.AutoSize = true;
            chkLoopAlbum.Location = new Point(591, 369);
            chkLoopAlbum.Name = "chkLoopAlbum";
            chkLoopAlbum.Size = new Size(92, 19);
            chkLoopAlbum.TabIndex = 14;
            chkLoopAlbum.Text = "Loop Album";
            chkLoopAlbum.UseVisualStyleBackColor = true;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(26, 381);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(34, 15);
            lblCurrentTime.TabIndex = 15;
            lblCurrentTime.Text = "00:00";
            // 
            // lblTotalTime
            // 
            lblTotalTime.AutoSize = true;
            lblTotalTime.Location = new Point(187, 381);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(34, 15);
            lblTotalTime.TabIndex = 16;
            lblTotalTime.Text = "00:00";
            // 
            // trackBarTime
            // 
            trackBarTime.Location = new Point(67, 381);
            trackBarTime.Maximum = 100;
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(104, 45);
            trackBarTime.TabIndex = 17;
            trackBarTime.TickStyle = TickStyle.None;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarTime);
            Controls.Add(lblTotalTime);
            Controls.Add(lblCurrentTime);
            Controls.Add(chkLoopAlbum);
            Controls.Add(chkLoopTrack);
            Controls.Add(trkVolume);
            Controls.Add(lstAlbums);
            Controls.Add(lstArtists);
            Controls.Add(lblArtist);
            Controls.Add(lblAlbum);
            Controls.Add(picArtist);
            Controls.Add(picAlbumCover);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(lstSongs);
            Controls.Add(lblStatus);
            Controls.Add(btnPlay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAlbumCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)picArtist).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Label lblStatus;
        private ListBox lstSongs;
        private Button btnPause;
        private Button btnStop;
        private PictureBox picAlbumCover;
        private PictureBox picArtist;
        private Label lblAlbum;
        private Label lblArtist;
        private ListBox lstArtists;
        private ListBox lstAlbums;
        private TrackBar trkVolume;
        private CheckBox chkLoopTrack;
        private CheckBox chkLoopAlbum;
        private Label lblCurrentTime;
        private Label lblTotalTime;
        private TrackBar trackBarTime;
    }
}
