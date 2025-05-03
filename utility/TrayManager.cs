namespace MusicPlayer.utility
{
    public class TrayManager
    {
        private readonly Form _form;
        private readonly NotifyIcon _trayIcon;

        public TrayManager(Form form, NotifyIcon trayIcon)
        {
            _form = form;
            _trayIcon = trayIcon;

            InitializeTray();
        }

        private void InitializeTray()
        {
            ContextMenuStrip trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, (s, e) => ShowFromTray());
            trayMenu.Items.Add("Exit", null, (s, e) => Application.Exit());

            _trayIcon.ContextMenuStrip = trayMenu;
            _trayIcon.DoubleClick += (s, e) => ShowFromTray();
        }

        public void ShowFromTray()
        {
            _form.Show();
            _form.WindowState = FormWindowState.Normal;
            _form.BringToFront();
        }

        public void MinimizeToTray()
        {
            _form.Hide();
            _trayIcon.ShowBalloonTip(1000, "Music Player", "Running in system tray", ToolTipIcon.Info);
        }
    }
}
