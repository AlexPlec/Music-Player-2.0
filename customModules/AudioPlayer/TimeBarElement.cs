using NAudio.Wave;

namespace MusicPlayer.customModules.AudioPlayer
{
    public partial class TimeBarElement : UserControl
    {
        private AudioFileReader? audioFileReader;
        private WaveOutEvent? outputDevice;
        private bool wasPlayingBeforeSeek = false;

        public TimeBarElement()
        {
            InitializeComponent();

            trackBarTime.MouseDown += OnTrackBarMouseDown;
            trackBarTime.MouseUp += OnTrackBarMouseUp;
            trackBarTime.Scroll += OnTrackBarScroll;
        }

        private void OnTrackBarMouseDown(object? sender, MouseEventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                wasPlayingBeforeSeek = true;
                outputDevice.Stop();
            }
            else
            {
                wasPlayingBeforeSeek = false;
            }
        }

        private void OnTrackBarMouseUp(object? sender, MouseEventArgs e)
        {
            if (outputDevice != null && wasPlayingBeforeSeek)
            {
                outputDevice.Play();
            }
        }

        private void OnTrackBarScroll(object? sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                var pos = TimeSpan.FromSeconds(trackBarTime.Value);
                audioFileReader.CurrentTime = pos;
            }
        }

        public void SetDuration(TimeSpan total)
        {
            trackBarTime.Maximum = (int)total.TotalSeconds;
            songDuration.Text = total.ToString(@"mm\:ss");
        }

        public void SetPosition(TimeSpan current)
        {
            trackBarTime.Value = (int)current.TotalSeconds;
            songCurrentTime.Text = current.ToString(@"mm\:ss");
        }

        public void SetPlaybackDevices(AudioFileReader reader, WaveOutEvent device)
        {
            audioFileReader = reader;
            outputDevice = device;
        }
    }
}
