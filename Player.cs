using NAudio.Wave;

namespace MusicPlayer
{
    public class Player
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        private List<MusicMetadata.Song> playlist = new();
        private int currentIndex = 0;

        public bool LoopAlbum { get; set; } = false;
        public bool LoopTrack { get; set; } = false;
        public bool IsPlaying => waveOut?.PlaybackState == PlaybackState.Playing;
        public TimeSpan CurrentTime => audioFileReader?.CurrentTime ?? TimeSpan.Zero;
        public TimeSpan TotalTime => audioFileReader?.TotalTime ?? TimeSpan.Zero;

        public event EventHandler PlaybackStopped;

        public void SetPlaylist(List<MusicMetadata.Song> songs, int startIndex = 0)
        {
            playlist = songs;
            currentIndex = startIndex;
        }

        public void PlayCurrent()
        {
            if (playlist == null || playlist.Count == 0 || currentIndex >= playlist.Count)
                return;

            Play(playlist[currentIndex].FilePath);
        }

        public void Play(string filePath)
        {
            Stop();

            audioFileReader = new AudioFileReader(filePath);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFileReader);
            waveOut.PlaybackStopped += OnPlaybackStopped;
            waveOut.Play();
        }

        public void Pause()
        {
            if (waveOut?.PlaybackState == PlaybackState.Playing)
                waveOut.Pause();
        }

        public void Resume()
        {
            if (waveOut?.PlaybackState == PlaybackState.Paused)
                waveOut.Play();
        }

        public void Stop()
        {
            waveOut?.Stop();
            audioFileReader?.Dispose();
            waveOut?.Dispose();
            audioFileReader = null;
            waveOut = null;
        }

        public void Seek(TimeSpan time)
        {
            if (audioFileReader != null && time < audioFileReader.TotalTime)
            {
                audioFileReader.CurrentTime = time;
            }
        }

        public void SetVolume(float volume)
        {
            if (audioFileReader != null)
                audioFileReader.Volume = volume;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            audioFileReader?.Dispose();
            waveOut?.Dispose();
            audioFileReader = null;
            waveOut = null;

            if (LoopTrack)
            {
                PlayCurrent(); // Replay the same song
            }
            else
            {
                currentIndex++;

                if (currentIndex < playlist.Count)
                {
                    PlayCurrent();
                }
                else if (LoopAlbum)
                {
                    currentIndex = 0;
                    PlayCurrent();
                }
            }

            PlaybackStopped?.Invoke(this, EventArgs.Empty);
        }

        public void NextTrack()
        {
            if (playlist == null || playlist.Count == 0)
                return;

            currentIndex++;
            if (currentIndex >= playlist.Count)
            {
                if (LoopAlbum)
                    currentIndex = 0;
                else
                    return;
            }
            //  System.Diagnostics.Debug.WriteLine(currentIndex);
            PlayCurrent();
        }

        public void PreviousTrack()
        {
            if (playlist == null || playlist.Count == 0)
                return;

            currentIndex--;
            if (currentIndex < 0)
            {
                if (LoopAlbum)
                    currentIndex = playlist.Count - 1;
                else
                    return;
            }

            PlayCurrent();
        }

    }
}
