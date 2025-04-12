namespace MusicPlayer
{
    public class VolumeManager
    {
        private readonly Player player;
        private readonly TrackBar trackBar;
        private readonly Label lblVolumeLevel;

        public VolumeManager(Player player, TrackBar trackBar, Label lblVolumeLevel)
        {
            this.player = player;
            this.trackBar = trackBar;
            this.lblVolumeLevel = lblVolumeLevel;

            // Initialize volume level from TrackBar value
            UpdateVolumeLabel();

            // Bind the TrackBar to volume change
            trackBar.Scroll += TrackBar_Scroll;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            // Get the volume value from TrackBar (0 to 100)
            float volume = trackBar.Value / 100f;

            // Set volume in the player
            player.SetVolume(volume);

            // Update the volume level label
            UpdateVolumeLabel();
        }

        private void UpdateVolumeLabel()
        {
            // Update the label to show the current volume level
            lblVolumeLevel.Text = trackBar.Value.ToString();
        }
    }
}
