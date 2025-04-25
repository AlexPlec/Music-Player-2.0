namespace MusicPlayer.customModules.Views.albums.albumsView
{
    partial class Albums
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
            albumsLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // albumsLayout
            // 
            albumsLayout.AutoScroll = true;
            albumsLayout.FlowDirection = FlowDirection.TopDown;
            albumsLayout.Location = new Point(3, 3);
            albumsLayout.Name = "albumsLayout";
            albumsLayout.Size = new Size(96, 100);
            albumsLayout.TabIndex = 0;
            albumsLayout.WrapContents = false;
            // 
            // Albums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(albumsLayout);
            Name = "Albums";
            Size = new Size(105, 110);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel albumsLayout;
    }
}
