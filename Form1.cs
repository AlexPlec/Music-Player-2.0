namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioPlayer player = new AudioPlayer();
        private Dictionary<string, string> musicFiles = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            btnPlay.Click += (s, e) => player.Play();
            btnPause.Click += (s, e) => player.Pause();
            btnStop.Click += (s, e) => player.Stop();
            lstSongs.DoubleClick += lstSongs_DoubleClick;
        }

        private void lstSongs_DoubleClick(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem == null) return;

            string selected = lstSongs.SelectedItem.ToString();
            if (!musicFiles.TryGetValue(selected, out string path)) return;

            player.Load(path);
            player.Play();

            var meta = MetadataReader.GetMetadata(path);
            lblStatus.Text = meta.Title;
            lblArtist.Text = meta.Artist;
            lblAlbum.Text = meta.Album;

            LoadImages(path);
        }

        private void LoadImages(string filePath)
        {
            string folder = Path.GetDirectoryName(filePath);
            string albumCover = Path.Combine(folder, "cover.jpg");
            string artistCover = Directory.GetParent(folder)?.FullName + "\\artist.jpg";

            picAlbumCover.Image = File.Exists(albumCover)
                ? Image.FromStream(new MemoryStream(File.ReadAllBytes(albumCover)))
                : null;

            picArtist.Image = File.Exists(artistCover)
                ? Image.FromStream(new MemoryStream(File.ReadAllBytes(artistCover)))
                : null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string musicDir = @"C:\Users\accht\Documents\GitHub\Music-Player-2.0\musicFiles";
            if (!Directory.Exists(musicDir)) return;

            var files = Directory.GetFiles(musicDir, "*.*", SearchOption.AllDirectories)
                                 .Where(f => f.EndsWith(".mp3") || f.EndsWith(".wav"));

            foreach (var file in files)
            {
                string name = Path.GetFileName(file);
                if (!musicFiles.ContainsKey(name))
                {
                    musicFiles.Add(name, file);
                    lstSongs.Items.Add(name);
                }
            }
        }
    }


}
