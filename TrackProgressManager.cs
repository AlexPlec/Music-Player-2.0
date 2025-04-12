using Timer = System.Windows.Forms.Timer;

namespace MusicPlayer
{
    public class TrackProgressManager
    {
        private readonly Player player;
        private readonly Timer timer;
        private readonly TrackBar trackBar;
        private readonly Label lblCurrentTime;
        private readonly Label lblTotalTime;
        private bool wasPlayingBeforeDrag = false;
        private bool isDragging = false;

        public TrackProgressManager(Player player, Timer timer, TrackBar trackBar, Label lblCurrentTime, Label lblTotalTime)
        {
            this.player = player;
            this.timer = timer;
            this.trackBar = trackBar;
            this.lblCurrentTime = lblCurrentTime;
            this.lblTotalTime = lblTotalTime;

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            trackBar.Scroll += TrackBar_Scroll;
            trackBar.MouseDown += TrackBar_MouseDown;
            trackBar.MouseUp += TrackBar_MouseUp;
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (player.IsPlaying && !isDragging)
            {
                TimeSpan current = player.CurrentTime;
                TimeSpan total = player.TotalTime;

                lblCurrentTime.Text = current.ToString(@"mm\:ss");
                lblTotalTime.Text = total.ToString(@"mm\:ss");

                if (total.TotalSeconds > 0)
                {
                    trackBar.Value = Math.Min(trackBar.Maximum,
                        (int)((current.TotalSeconds / total.TotalSeconds) * trackBar.Maximum));
                }
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (player.TotalTime.TotalSeconds > 0)
            {
                double targetSeconds = (trackBar.Value / (double)trackBar.Maximum) * player.TotalTime.TotalSeconds;

                TimeSpan targetTime = TimeSpan.FromSeconds(targetSeconds);
                lblCurrentTime.Text = targetTime.ToString(@"mm\:ss");

                if (player.IsPlaying)
                {
                    player.Seek(targetTime);
                }
            }
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (player.IsPlaying)
            {
                wasPlayingBeforeDrag = true;
                player.Pause();
            }
            else
            {
                wasPlayingBeforeDrag = false;
            }

            isDragging = true;
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (player.TotalTime.TotalSeconds > 0)
            {
                double targetSeconds = (trackBar.Value / (double)trackBar.Maximum) * player.TotalTime.TotalSeconds;
                player.Seek(TimeSpan.FromSeconds(targetSeconds));
            }

            isDragging = false;

            if (wasPlayingBeforeDrag)
            {
                player.Resume();
            }
        }
    }
}
