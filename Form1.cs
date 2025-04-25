using MusicPlayer.metadata;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicMetadata musicMetadata;
        private Stack<Control> navigationHistory = new Stack<Control>();
        public Form1()
        {
            InitializeComponent();
            musicMetadata = new MusicMetadata();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMetadata();
            btnBack.Click += BtnBack_Click;
            artistsView.SetArtists(musicMetadata.GetArtists());
            artistsView.ArtistSelected += OnArtistSelected;
            artistAlbumsView.AlbumSelected += OnAlbumSelected;
            albumsView.SetAlbums(musicMetadata.GetAlbums(), musicMetadata.GetArtists());
            btnArtists.Click += (s, e) => ShowView(artistsView);
            btnAlbums.Click += (s, e) => ShowView(albumsView);
            albumsView.AlbumSelected += OnAlbumSelected;

        }
        private void OnAlbumSelected(MusicMetadata.AlbumCacheItem album)
        {
            navigationHistory.Push(artistAlbumsView);
            artistAlbumsView.Visible = false;
            var artist = musicMetadata.GetArtists().FirstOrDefault(a => a.Id == album.ArtistId);
            var songs = musicMetadata.GetSongs()
             .Where(s => s.AlbumId == album.Id)
             .OrderBy(s => s.Track)
             .ToList();
            artistAlbumSongsView.SetSongs(album, artist, songs);
            artistAlbumSongsView.Visible = true;
        }
        private void OnArtistSelected(MusicMetadata.ArtistCacheItem artist)
        {
            navigationHistory.Push(artistsView);
            artistsView.Visible = false;

            var artistAlbums = musicMetadata.GetAlbums().Where(a => a.ArtistId == artist.Id).ToList();
            artistAlbumsView.SetAlbums(artistAlbums, artist);
            artistAlbumsView.Visible = true;
        }
        //    System.Diagnostics.Debug.WriteLine(lstSongs.SelectedItem);
        private void InitializeMetadata()
        {

            musicMetadata.LoadArtistCache();
            musicMetadata.LoadAlbumsCache();
            musicMetadata.LoadSongsCache();

            if (musicMetadata.GetArtists().Count == 0 ||
                musicMetadata.GetAlbums().Count == 0 ||
                musicMetadata.GetSongs().Count == 0)
            {
                musicMetadata.CreateAllCaches();
            }
        }
        private void BtnBack_Click(object? sender, EventArgs e)
        {
            if (navigationHistory.Count > 0)
            {
                Control lastView = navigationHistory.Pop();

                // Hide all views
                artistsView.Visible = false;
                artistAlbumsView.Visible = false;
                artistAlbumSongsView.Visible = false;

                lastView.Visible = true;
            }
        }

        private void ShowView(Control viewToShow)
        {
            // Hide all views
            artistsView.Visible = false;
            artistAlbumsView.Visible = false;
            artistAlbumSongsView.Visible = false;
            albumsView.Visible = false;

            // Optionally keep track of navigation history
            if (!navigationHistory.Contains(viewToShow))
            {
                navigationHistory.Push(viewToShow);
            }

            // Show the selected view
            viewToShow.Visible = true;
        }
    }
}