using NAudio.Wave;

namespace MusicPlayer
{
    public class Player
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;

        public bool IsPlaying => waveOut?.PlaybackState == PlaybackState.Playing;
        public TimeSpan CurrentTime => audioFileReader?.CurrentTime ?? TimeSpan.Zero;
        public TimeSpan TotalTime => audioFileReader?.TotalTime ?? TimeSpan.Zero;

        public void Play(string filePath)
        {
            Stop(); // Stop previous if any

            audioFileReader = new AudioFileReader(filePath);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFileReader);
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


        public void SetVolume(float volume) // volume from 0.0f to 1.0f
        {
            if (audioFileReader != null)
                audioFileReader.Volume = volume;
        }
    }
}
