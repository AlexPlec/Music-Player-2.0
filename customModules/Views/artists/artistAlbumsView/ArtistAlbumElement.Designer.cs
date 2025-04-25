namespace MusicPlayer.customModules.Views.artists.artistAlbumsView
{
    partial class ArtistAlbumElement
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
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(0, 56);
            albumTitle.Name = "albumTitle";
            albumTitle.Size = new Size(43, 15);
            albumTitle.TabIndex = 1;
            albumTitle.Text = "Album";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(0, 71);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 2;
            artistTitle.Text = "Artist";
            // 
            // ArtistAlbumsElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(artistTitle);
            Controls.Add(albumTitle);
            Controls.Add(albumCover);
            Name = "ArtistAlbumsElement";
            Size = new Size(105, 90);
            ((System.ComponentModel.ISupportInitialize)albumCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox albumCover;
        private Label albumTitle;
        private Label artistTitle;
    }
}
