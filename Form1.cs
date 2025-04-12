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

            musicMetadata.LoadCache();

            if (musicMetadata.GetAllArtists().Count == 0)
            {
                musicMetadata.LoadMetada();
                musicMetadata.SaveCache();
            }

            artists = musicMetadata.GetAllArtists();

            musicLibraryLoader = new MusicLibraryLoader(lstArtists, lstAlbums, lstSongs);
            musicLibraryLoader.LoadLibrary(artists);

            lstSongs.SelectedIndexChanged += lstSongs_SelectedIndexChanged;

            volumeManager = new VolumeManager(player, trkVolume, lblVolumeLevel);

            progressManager = new TrackProgressManager(player, timerProgress, trackBarProgress, lblCurrentTime, lblTotalTime);
            progressManager.Start();
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    System.Diagnostics.Debug.WriteLine(lstSongs.SelectedItem);

            if (lstSongs.SelectedItem is SongListItem selectedItem)
            {
                var song = selectedItem.Song;
                player.Play(song.FilePath);
                System.Diagnostics.Debug.WriteLine($"Playing: {song.Title}, File: {song.FilePath}");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Resume();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
