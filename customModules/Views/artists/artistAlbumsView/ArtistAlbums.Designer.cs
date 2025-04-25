namespace MusicPlayer.customModules.Views.artists.artistAlbumsView
{
    partial class ArtistAlbums
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
            artistAlbumsLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // artistAlbumsLayout
            // 
            artistAlbumsLayout.AutoScroll = true;
            artistAlbumsLayout.FlowDirection = FlowDirection.TopDown;
            artistAlbumsLayout.Location = new Point(3, 3);
            artistAlbumsLayout.Name = "artistAlbumsLayout";
            artistAlbumsLayout.Size = new Size(144, 144);
            artistAlbumsLayout.TabIndex = 0;
            artistAlbumsLayout.WrapContents = false;
            // 
            // ArtistAlbums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(artistAlbumsLayout);
            Name = "ArtistAlbums";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel artistAlbumsLayout;
    }
}
