using MusicPlayer.customModules.AudioPlayer;
using MusicPlayer.metadata;
using MusicPlayer.utility;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicMetadata musicMetadata;
        private Stack<Control> navigationHistory = new Stack<Control>();
        private bool artistsInitialized = false;
        private bool albumsInitialized = false;
        private GlobalKeyHandler globalKeyHandler;
        private TrayManager trayManager;

        public Form1()
        {
            InitializeComponent();
            musicMetadata = new MusicMetadata();
            trayManager = new TrayManager(this, trayIcon);
            FormClosing += Form1_FormClosing;
            Application.ApplicationExit += OnApplicationExit;
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            audioPlayer?.SaveHistory();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMetadata();
            InitializeButtons();
            globalKeyHandler = new GlobalKeyHandler(this, audioPlayer.ButtonsElementControl);

            var history = PlayerHistory.Load();

            if (history != null && history.Song != null)
            {
                audioPlayer.LoadSong(history.Artist, history.Album, history.Song, history.Playlist);
                audioPlayer.outputDevice.Stop();
                audioPlayer.audioFileReader.CurrentTime = TimeSpan.FromSeconds(history.TrackPositionSeconds);
                audioPlayer.VolumeElement.CurrentVolume = history.Volume;
                audioPlayer.ButtonsElementControl.BtnPlay.Text = "Stop";
                audioPlayer.isPlaying = false;
                if (Enum.TryParse(history.RepeatMode, out ButtonsElement.RepeatMode mode))
                {
                    audioPlayer.ButtonsElementControl.repeatMode = mode;
                    audioPlayer.ButtonsElementControl.UpdateRepeatButtonText();
                }
            }
        }
        private void InitializeButtons()
        {
            btnBack.Click += BtnBack_Click;
            btnArtists.Click += (s, e) => ShowView(artistsView);
            btnAlbums.Click += (s, e) => ShowView(albumsView);
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
        //    System.Diagnostics.Debug.WriteLine("test");
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

            artistsView.Visible = false;
            artistAlbumsView.Visible = false;
            artistAlbumSongsView.Visible = false;
            albumsView.Visible = false;

            if (!navigationHistory.Contains(viewToShow))
            {
                navigationHistory.Push(viewToShow);
            }

            viewToShow.Visible = true;

            if (viewToShow == artistsView && !artistsInitialized)
            {
                artistsInitialized = true;
                artistsView.SetArtists(musicMetadata.GetArtists());
                artistsView.ArtistSelected += OnArtistSelected;

                artistAlbumsView.AlbumSelected += OnAlbumSelected;
            }
            if (viewToShow == albumsView && !albumsInitialized)
            {
                albumsInitialized = true;
                albumsView.SetAlbums(musicMetadata.GetAlbums(), musicMetadata.GetArtists());
                albumsView.AlbumSelected += OnAlbumSelected;
            }
        }
    }
}