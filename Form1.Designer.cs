namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnArtists = new Button();
            btnAlbums = new Button();
            btnPlaylists = new Button();
            ViewPanel = new Panel();
            albumsView = new customModules.Views.albums.albumsView.Albums();
            artistAlbumSongsView = new customModules.Views.artists.artistAlbumSongsView.ArtistAlbumSongs();
            artistAlbumsView = new customModules.Views.artists.artistAlbumsView.ArtistAlbums();
            artistsView = new customModules.Views.artists.artistsView.Artists();
            artistsViewForm = new customModules.Views.artists.artistsView.Artists();
            btnBack = new Button();
            ViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnArtists
            // 
            btnArtists.Location = new Point(274, 12);
            btnArtists.Name = "btnArtists";
            btnArtists.Size = new Size(75, 23);
            btnArtists.TabIndex = 20;
            btnArtists.Text = "Artists";
            btnArtists.UseVisualStyleBackColor = true;
            // 
            // btnAlbums
            // 
            btnAlbums.Location = new Point(355, 12);
            btnAlbums.Name = "btnAlbums";
            btnAlbums.Size = new Size(75, 23);
            btnAlbums.TabIndex = 21;
            btnAlbums.Text = "Albums";
            btnAlbums.UseVisualStyleBackColor = true;
            // 
            // btnPlaylists
            // 
            btnPlaylists.Location = new Point(436, 12);
            btnPlaylists.Name = "btnPlaylists";
            btnPlaylists.Size = new Size(75, 23);
            btnPlaylists.TabIndex = 22;
            btnPlaylists.Text = "Playlists";
            btnPlaylists.UseVisualStyleBackColor = true;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(albumsView);
            ViewPanel.Controls.Add(artistAlbumSongsView);
            ViewPanel.Controls.Add(artistAlbumsView);
            ViewPanel.Controls.Add(artistsView);
            ViewPanel.Controls.Add(artistsViewForm);
            ViewPanel.Location = new Point(170, 100);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(491, 503);
            ViewPanel.TabIndex = 0;
            // 
            // albumsView
            // 
            albumsView.Location = new Point(315, 12);
            albumsView.Name = "albumsView";
            albumsView.Size = new Size(148, 120);
            albumsView.TabIndex = 4;
            albumsView.Visible = false;
            // 
            // artistAlbumSongsView
            // 
            artistAlbumSongsView.Location = new Point(3, 159);
            artistAlbumSongsView.Name = "artistAlbumSongsView";
            artistAlbumSongsView.Size = new Size(210, 180);
            artistAlbumSongsView.TabIndex = 3;
            artistAlbumSongsView.Visible = false;
            // 
            // artistAlbumsView
            // 
            artistAlbumsView.Location = new Point(159, 12);
            artistAlbumsView.Name = "artistAlbumsView";
            artistAlbumsView.Size = new Size(150, 150);
            artistAlbumsView.TabIndex = 2;
            // 
            // artistsView
            // 
            artistsView.Location = new Point(3, 3);
            artistsView.Name = "artistsView";
            artistsView.Size = new Size(150, 150);
            artistsView.TabIndex = 1;
            // 
            // artistsViewForm
            // 
            artistsViewForm.Location = new Point(3, 3);
            artistsViewForm.Name = "artistsViewForm";
            artistsViewForm.Size = new Size(150, 150);
            artistsViewForm.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 23;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 615);
            Controls.Add(btnBack);
            Controls.Add(ViewPanel);
            Controls.Add(btnPlaylists);
            Controls.Add(btnAlbums);
            Controls.Add(btnArtists);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ViewPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnArtists;
        private Button btnAlbums;
        private Button btnPlaylists;
        private Panel ViewPanel;
        private Button btnBack;
        private customModules.Views.artists.artistsView.Artists artistsViewForm;
        private customModules.Views.artists.artistsView.Artists artistsView;
        private customModules.Views.artists.artistAlbumsView.ArtistAlbums artistAlbumsView;
        private customModules.Views.artists.artistAlbumSongsView.ArtistAlbumSongs artistAlbumSongsView;
        private customModules.Views.albums.albumsView.Albums albumsView;
    }
}
