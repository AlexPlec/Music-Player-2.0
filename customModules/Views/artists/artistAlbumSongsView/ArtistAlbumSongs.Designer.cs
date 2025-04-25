namespace MusicPlayer.customModules.Views.artists.artistAlbumSongsView
{
    partial class ArtistAlbumSongs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            songsLayout = new FlowLayoutPanel();
            albumCover = new PictureBox();
            albumTitle = new Label();
            artistTitle = new Label();
            songNumber = new Label();
            songTitle = new Label();
            songArtist = new Label();
            songAlbum = new Label();
            songDuration = new Label();
            ((System.ComponentModel.ISupportInitialize)albumCover).BeginInit();
            SuspendLayout();
            // 
            // songsLayout
            // 
            songsLayout.AutoScroll = true;
            songsLayout.FlowDirection = FlowDirection.TopDown;
            songsLayout.Location = new Point(3, 74);
            songsLayout.Name = "songsLayout";
            songsLayout.Size = new Size(200, 100);
            songsLayout.TabIndex = 0;
            songsLayout.WrapContents = false;
            // 
            // albumCover
            // 
            albumCover.Location = new Point(3, 3);
            albumCover.Name = "albumCover";
            albumCover.Size = new Size(100, 50);
            albumCover.TabIndex = 1;
            albumCover.TabStop = false;
            // 
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(109, 3);
            albumTitle.Name = "albumTitle";
            albumTitle.Size = new Size(43, 15);
            albumTitle.TabIndex = 2;
            albumTitle.Text = "Album";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(109, 38);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 3;
            artistTitle.Text = "Artist";
            // 
            // songNumber
            // 
            songNumber.AutoSize = true;
            songNumber.Location = new Point(3, 56);
            songNumber.Name = "songNumber";
            songNumber.Size = new Size(14, 15);
            songNumber.TabIndex = 4;
            songNumber.Text = "#";
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Location = new Point(23, 56);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(34, 15);
            songTitle.TabIndex = 5;
            songTitle.Text = "Song";
            // 
            // songArtist
            // 
            songArtist.AutoSize = true;
            songArtist.Location = new Point(63, 56);
            songArtist.Name = "songArtist";
            songArtist.Size = new Size(35, 15);
            songArtist.TabIndex = 6;
            songArtist.Text = "Artist";
            // 
            // songAlbum
            // 
            songAlbum.AutoSize = true;
            songAlbum.Location = new Point(104, 56);
            songAlbum.Name = "songAlbum";
            songAlbum.Size = new Size(43, 15);
            songAlbum.TabIndex = 7;
            songAlbum.Text = "Album";
            // 
            // songDuration
            // 
            songDuration.AutoSize = true;
            songDuration.Location = new Point(153, 56);
            songDuration.Name = "songDuration";
            songDuration.Size = new Size(53, 15);
            songDuration.TabIndex = 8;
            songDuration.Text = "Duration";
            // 
            // ArtistAlbumSongs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(songDuration);
            Controls.Add(songAlbum);
            Controls.Add(songArtist);
            Controls.Add(songTitle);
            Controls.Add(songNumber);
            Controls.Add(artistTitle);
            Controls.Add(albumTitle);
            Controls.Add(albumCover);
            Controls.Add(songsLayout);
            Name = "ArtistAlbumSongs";
            Size = new Size(210, 180);
            ((System.ComponentModel.ISupportInitialize)albumCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel songsLayout;
        private PictureBox albumCover;
        private Label albumTitle;
        private Label artistTitle;
        private Label songNumber;
        private Label songTitle;
        private Label songArtist;
        private Label songAlbum;
        private Label songDuration;
    }
}
