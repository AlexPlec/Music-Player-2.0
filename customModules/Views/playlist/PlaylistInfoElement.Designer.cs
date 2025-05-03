namespace MusicPlayer.customModules.Views.playlist
{
    partial class PlaylistInfoElement
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
            playlistCover = new PictureBox();
            playlistTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)playlistCover).BeginInit();
            SuspendLayout();
            // 
            // playlistCover
            // 
            playlistCover.Location = new Point(3, 3);
            playlistCover.Name = "playlistCover";
            playlistCover.Size = new Size(100, 50);
            playlistCover.TabIndex = 1;
            playlistCover.TabStop = false;
            // 
            // playlistTitle
            // 
            playlistTitle.AutoSize = true;
            playlistTitle.Location = new Point(110, 20);
            playlistTitle.Name = "playlistTitle";
            playlistTitle.Size = new Size(44, 15);
            playlistTitle.TabIndex = 2;
            playlistTitle.Text = "Playlist";
            // 
            // PlaylistInfoElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(playlistTitle);
            Controls.Add(playlistCover);
            Name = "PlaylistInfoElement";
            Size = new Size(155, 60);
            ((System.ComponentModel.ISupportInitialize)playlistCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox playlistCover;
        private Label playlistTitle;
    }
}
