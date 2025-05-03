namespace MusicPlayer.customModules.Views.playlist
{
    partial class PlaylistSearchElement
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
            songsSearch = new TextBox();
            songsList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // songsSearch
            // 
            songsSearch.Location = new Point(3, 3);
            songsSearch.Name = "songsSearch";
            songsSearch.PlaceholderText = "search for songs";
            songsSearch.Size = new Size(100, 23);
            songsSearch.TabIndex = 0;
            // 
            // songsList
            // 
            songsList.AutoScroll = true;
            songsList.FlowDirection = FlowDirection.TopDown;
            songsList.Location = new Point(3, 32);
            songsList.Name = "songsList";
            songsList.Size = new Size(200, 100);
            songsList.TabIndex = 1;
            songsList.WrapContents = false;
            // 
            // PlaylistSearchElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(songsList);
            Controls.Add(songsSearch);
            Name = "PlaylistSearchElement";
            Size = new Size(210, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox songsSearch;
        private FlowLayoutPanel songsList;
    }
}
