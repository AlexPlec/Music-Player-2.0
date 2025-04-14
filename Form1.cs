using static MusicPlayer.MusicMetadata;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicMetadata musicMetadata;
        private MusicLibraryLoader musicLibraryLoader;
        private List<Artist> artists;
        private Player player = new Player();
        private TrackProgressManager progressManager;
        private VolumeManager volumeManager;

        public Form1()
        {
            InitializeComponent();
            musicMetadata = new MusicMetadata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMetadata();
            LoadAndDisplayLibrary();
            HookEvents();
            InitializeProgressManager();
            ConfigureLoopControls();
            volumeManager = new VolumeManager(player, trkVolume, lblVolumeLevel);
        }

        //    System.Diagnostics.Debug.WriteLine(lstSongs.SelectedItem);

        private void InitializeMetadata()
        {
            musicMetadata.LoadCache();

            if (musicMetadata.GetAllArtists().Count == 0)
            {
                musicMetadata.LoadMetada();
                musicMetadata.SaveCache();
            }

            artists = musicMetadata.GetAllArtists();
        }

        private void LoadAndDisplayLibrary()
        {
            musicLibraryLoader = new MusicLibraryLoader(lstArtists, lstAlbums, lstSongs);
            musicLibraryLoader.LoadLibrary(artists);
        }

        private void HookEvents()
        {
            lstSongs.SelectedIndexChanged += OnSongSelected;
        }

        private void InitializeProgressManager()
        {
            progressManager = new TrackProgressManager(player, timerProgress, trackBarProgress, lblCurrentTime, lblTotalTime);
            progressManager.Start();
        }

        private void ConfigureLoopControls()
        {
            chkLoopTrack.CheckedChanged += (s, e) =>
            {
                player.LoopTrack = chkLoopTrack.Checked;
                if (chkLoopTrack.Checked)
                    chkLoopAlbum.Checked = false;
            };

            chkLoopAlbum.CheckedChanged += (s, e) =>
            {
                player.LoopAlbum = chkLoopAlbum.Checked;
                if (chkLoopAlbum.Checked)
                    chkLoopTrack.Checked = false;
            };
        }

        private void OnSongSelected(object sender, EventArgs e)
        {
            if (lstAlbums.SelectedItem is AlbumListItem albumItem &&
                lstSongs.SelectedItem is SongListItem selectedItem)
            {
                PlaySelectedSong(albumItem, selectedItem);
            }
        }

        private void PlaySelectedSong(AlbumListItem albumItem, SongListItem selectedItem)
        {
            var albumSongs = albumItem.Album.Songs;
            int songIndex = albumSongs.IndexOf(selectedItem.Song);

            player.SetPlaylist(albumSongs, songIndex);
            player.PlayCurrent();

            System.Diagnostics.Debug.WriteLine($"Playing: {selectedItem.Song.Title}");
        }
        //for future change from up/down to left/right because of LstSongs
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                player.NextTrack();
                return true;
            }
            else if (keyData == Keys.Left)
            {
                player.PreviousTrack();
                return true;
            }
            else if (keyData == Keys.Space)
            {
                if (player.IsPlaying)
                    player.Pause();
                else
                    player.Resume();

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
