namespace MusicPlayer.customModules.Views.artists.artistsView
{
    partial class Artists
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
            ArtistViewLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ArtistViewLayout
            // 
            ArtistViewLayout.AutoScroll = true;
            ArtistViewLayout.FlowDirection = FlowDirection.TopDown;
            ArtistViewLayout.Location = new Point(3, 3);
            ArtistViewLayout.Name = "ArtistViewLayout";
            ArtistViewLayout.Size = new Size(144, 144);
            ArtistViewLayout.TabIndex = 0;
            ArtistViewLayout.WrapContents = false;
            // 
            // ArtistsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ArtistViewLayout);
            Name = "ArtistsView";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ArtistViewLayout;
    }
}
