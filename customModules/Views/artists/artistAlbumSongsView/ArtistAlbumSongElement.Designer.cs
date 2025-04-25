namespace MusicPlayer.customModules.Views.artists.artistAlbumSongsView
{
    partial class ArtistAlbumSongElement
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
            songNumber = new Label();
            songTitle = new Label();
            artistTitle = new Label();
            albumTitle = new Label();
            songDuration = new Label();
            SuspendLayout();
            // 
            // songNumber
            // 
            songNumber.AutoSize = true;
            songNumber.Location = new Point(3, 0);
            songNumber.Name = "songNumber";
            songNumber.Size = new Size(13, 15);
            songNumber.TabIndex = 0;
            songNumber.Text = "1";
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Location = new Point(22, 0);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(34, 15);
            songTitle.TabIndex = 1;
            songTitle.Text = "Song";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(62, 0);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 2;
            artistTitle.Text = "Artist";
            // 
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(103, 0);
            albumTitle.Name = "albumTitle";
            albumTitle.Size = new Size(43, 15);
            albumTitle.TabIndex = 3;
            albumTitle.Text = "Album";
            // 
            // songDuration
            // 
            songDuration.AutoSize = true;
            songDuration.Location = new Point(152, 0);
            songDuration.Name = "songDuration";
            songDuration.Size = new Size(28, 15);
            songDuration.TabIndex = 4;
            songDuration.Text = "0:00";
            // 
            // ArtistAlbumSongElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(songDuration);
            Controls.Add(albumTitle);
            Controls.Add(artistTitle);
            Controls.Add(songTitle);
            Controls.Add(songNumber);
            Name = "ArtistAlbumSongElement";
            Size = new Size(200, 25);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label songNumber;
        private Label songTitle;
        private Label artistTitle;
        private Label albumTitle;
        private Label songDuration;
    }
}
