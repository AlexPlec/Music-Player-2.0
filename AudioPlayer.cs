using NAudio.Wave;

namespace MusicPlayer
{
    public class AudioPlayer
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public void Load(string filePath)
        {
            Dispose();

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
        }

        public void Play()
        {
            outputDevice?.Play();
        }

        public void Pause()
        {
            outputDevice?.Pause();
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                if (audioFile != null) audioFile.Position = 0;
            }
        }

        public void Dispose()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;

            audioFile?.Dispose();
            audioFile = null;
        }
    }
}
