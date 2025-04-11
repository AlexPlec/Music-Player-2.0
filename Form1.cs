namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicMetadata musicMetadata;

        public Form1()
        {
            InitializeComponent();
            musicMetadata = new MusicMetadata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Try loading cache first
            musicMetadata.LoadCache();

            // If cache is empty, load metadata and save it
            if (musicMetadata.GetAllArtists().Count == 0)
            {
                musicMetadata.LoadMetada();
                musicMetadata.SaveCache(); // Save metadata to cache
            }

            var artists = musicMetadata.GetAllArtists();

            // Display artist names, albums, and songs for testing
            foreach (var artist in artists)
            {
                System.Diagnostics.Debug.WriteLine($"Artist: {artist.Name}");

                foreach (var album in artist.Albums)
                {
                    System.Diagnostics.Debug.WriteLine($"  Album: {album.Name}, Genre: {album.Genre}, Year: {album.Year}");

                    foreach (var song in album.Songs)
                    {
                        System.Diagnostics.Debug.WriteLine($"    Song: {song.Title}, Track: {song.Track}, File: {song.FilePath}");
                    }
                }
            }
        }

    }

}
