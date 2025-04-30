namespace MusicPlayer.customModules.AudioPlayer
{
    partial class SongInfoElement
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
            albumCover = new PictureBox();
            songTitle = new Label();
            albumTitle = new Label();
            artistTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)albumCover).BeginInit();
            SuspendLayout();
            // 
            // albumCover
            // 
            albumCover.Location = new Point(3, 3);
            albumCover.Name = "albumCover";
            albumCover.Size = new Size(100, 50);
            albumCover.TabIndex = 0;
            albumCover.TabStop = false;
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Location = new Point(109, 3);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(34, 15);
            songTitle.TabIndex = 1;
            songTitle.Text = "Song";
            // 
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(109, 20);
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
            // SongInfoElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(artistTitle);
            Controls.Add(albumTitle);
            Controls.Add(songTitle);
            Controls.Add(albumCover);
            Name = "SongInfoElement";
            Size = new Size(150, 60);
            ((System.ComponentModel.ISupportInitialize)albumCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox albumCover;
        private Label songTitle;
        private Label albumTitle;
        private Label artistTitle;
    }
}
