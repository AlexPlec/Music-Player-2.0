namespace MusicPlayer.customModules.Views.playlist
{
    partial class PlaylistSongElement
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
            songTitle = new Label();
            albumTitle = new Label();
            artistTitle = new Label();
            songCover = new PictureBox();
            addSongButton = new Button();
            ((System.ComponentModel.ISupportInitialize)songCover).BeginInit();
            SuspendLayout();
            // 
            // songTitle
            // 
            songTitle.AutoSize = true;
            songTitle.Location = new Point(59, 6);
            songTitle.Name = "songTitle";
            songTitle.Size = new Size(34, 15);
            songTitle.TabIndex = 0;
            songTitle.Text = "Song";
            // 
            // albumTitle
            // 
            albumTitle.AutoSize = true;
            albumTitle.Location = new Point(103, 6);
            albumTitle.Name = "albumTitle";
            albumTitle.Size = new Size(43, 15);
            albumTitle.TabIndex = 1;
            albumTitle.Text = "Album";
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(147, 6);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 2;
            artistTitle.Text = "Artist";
            // 
            // songCover
            // 
            songCover.Location = new Point(3, 3);
            songCover.Name = "songCover";
            songCover.Size = new Size(50, 25);
            songCover.TabIndex = 3;
            songCover.TabStop = false;
            // 
            // addSongButton
            // 
            addSongButton.Location = new Point(191, 3);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(75, 23);
            addSongButton.TabIndex = 4;
            addSongButton.Text = "Add";
            addSongButton.UseVisualStyleBackColor = true;
            // 
            // PlaylistSongElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addSongButton);
            Controls.Add(songCover);
            Controls.Add(artistTitle);
            Controls.Add(albumTitle);
            Controls.Add(songTitle);
            Name = "PlaylistSongElement";
            Size = new Size(270, 35);
            ((System.ComponentModel.ISupportInitialize)songCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label songTitle;
        private Label albumTitle;
        private Label artistTitle;
        private PictureBox songCover;
        private Button addSongButton;
    }
}
