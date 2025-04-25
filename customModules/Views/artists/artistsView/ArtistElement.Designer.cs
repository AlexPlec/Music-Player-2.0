namespace MusicPlayer.customModules.Views.artists.artistsView
{
    partial class ArtistElement
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
            artistCover = new PictureBox();
            artistTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)artistCover).BeginInit();
            SuspendLayout();
            // 
            // artistCover
            // 
            artistCover.Location = new Point(0, 3);
            artistCover.Name = "artistCover";
            artistCover.Size = new Size(100, 50);
            artistCover.TabIndex = 0;
            artistCover.TabStop = false;
            // 
            // artistTitle
            // 
            artistTitle.AutoSize = true;
            artistTitle.Location = new Point(3, 56);
            artistTitle.Name = "artistTitle";
            artistTitle.Size = new Size(35, 15);
            artistTitle.TabIndex = 1;
            artistTitle.Text = "Artist";
            // 
            // ArtistElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(artistTitle);
            Controls.Add(artistCover);
            Name = "ArtistElement";
            Size = new Size(105, 75);
            ((System.ComponentModel.ISupportInitialize)artistCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox artistCover;
        private Label artistTitle;
    }
}
