using MusicPlayer.utility;
using NAudio.Wave;
using static MusicPlayer.customModules.AudioPlayer.ButtonsElement;
using static MusicPlayer.metadata.MusicMetadata;

namespace MusicPlayer.customModules.AudioPlayer
{
    public partial class AudioPlayer : UserControl
    {
        public WaveOutEvent outputDevice;
        public AudioFileReader audioFileReader;
        public System.Windows.Forms.Timer playbackTimer;

        public List<SongCacheItem> currentAlbumSongs;

        public ArtistCacheItem currentArtist;
        public AlbumCacheItem currentAlbum;
        public SongCacheItem currentSong;

        public bool isPlaying = true;
        public ButtonsElement ButtonsElementControl => buttonsElement;

        public AudioPlayer()
        {
            InitializeComponent();

            buttonsElement.SetAudioPlayer(this);

            GlobalEvents.SongSelected += (artist, album, song, songs) =>
            {
                LoadSong(artist, album, song, songs);
            };
        }
        public void LoadSong(ArtistCacheItem artist, AlbumCacheItem album, SongCacheItem song, List<SongCacheItem> songList)
        {
            // Dispose previous
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFileReader?.Dispose();

            // Store current
            currentArtist = artist;
            currentAlbum = album;
            currentSong = song;
            currentAlbumSongs = songList;

            // Load into NAudio
            audioFileReader = new AudioFileReader(song.FilePath);
            outputDevice = new WaveOutEvent();
            volumeElement.SetOutputDevice(outputDevice);
            outputDevice.Volume = volumeElement.CurrentVolume;
            outputDevice.Init(audioFileReader);
            timeBarElement1.SetPlaybackDevices(audioFileReader, outputDevice);
            outputDevice.Play();
            outputDevice.PlaybackStopped += OnPlaybackStopped;

            // Update UI
            songInfoElement.SetSongInfo(artist, album, song);
            timeBarElement1.SetDuration(audioFileReader.TotalTime);

            StartPlaybackTimer();
            buttonsElement.BtnPlay.Text = "Play";
            isPlaying = true;
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFileReader != null && audioFileReader.CurrentTime >= audioFileReader.TotalTime - TimeSpan.FromMilliseconds(500))
            {
                if (buttonsElement.repeatMode == RepeatMode.RepeatSong)
                {
                    LoadSong(currentArtist, currentAlbum, currentSong, currentAlbumSongs);
                }
                else
                {
                    PlayNextSong();
                }
            }
        }
        private void PlayNextSong()
        {
            if (currentAlbumSongs == null || currentSong == null)
                return;

            int currentIndex = currentAlbumSongs.IndexOf(currentSong);
            if (currentIndex >= 0 && currentIndex < currentAlbumSongs.Count - 1)
            {
                var nextSong = currentAlbumSongs[currentIndex + 1];
                LoadSong(currentArtist, currentAlbum, nextSong, currentAlbumSongs);
            }
            else if (buttonsElement.repeatMode == RepeatMode.RepeatAlbum)
            {
                LoadSong(currentArtist, currentAlbum, currentAlbumSongs[0], currentAlbumSongs);
            }
        }
        private void StartPlaybackTimer()
        {
            playbackTimer?.Stop();
            playbackTimer = new System.Windows.Forms.Timer { Interval = 500 };
            playbackTimer.Tick += (_, __) =>
            {
                if (audioFileReader != null)
                    timeBarElement1.SetPosition(audioFileReader.CurrentTime);
            };
            playbackTimer.Start();
        }
    }
}
