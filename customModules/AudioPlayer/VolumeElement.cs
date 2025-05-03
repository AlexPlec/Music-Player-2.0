using NAudio.Wave;

namespace MusicPlayer.customModules.AudioPlayer
{
    public partial class VolumeElement : UserControl
    {
        private WaveOutEvent? outputDevice;
        public float CurrentVolume
        {
            get => volumeLevel.Value / 100f;
            set => volumeLevel.Value = (int)(value * 100);
        }
        public event Action<float>? VolumeChanged;
        public VolumeElement()
        {
            InitializeComponent();
            volumeLevel.ValueChanged += OnVolumeLevelChanged;
        }
        private void OnVolumeLevelChanged(object? sender, EventArgs e)
        {
            volumeLevelValue.Text = volumeLevel.Value.ToString();
            SetVolume(CurrentVolume);
            VolumeChanged?.Invoke(CurrentVolume);
        }
        public void SetOutputDevice(WaveOutEvent device)
        {
            outputDevice = device;
            SetVolume(CurrentVolume);
        }
        private void SetVolume(float volume)
        {
            if (outputDevice != null)
                outputDevice.Volume = volume;
        }
    }
}
