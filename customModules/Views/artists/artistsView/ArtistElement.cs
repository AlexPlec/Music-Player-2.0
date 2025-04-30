using MusicPlayer.metadata;
using MusicPlayer.utils;

namespace MusicPlayer.customModules.Views.artists.artistsView
{
    public partial class ArtistElement : UserControl
    {
        public ArtistElement()
        {
            InitializeComponent();
            Click += OnClick;
            foreach (Control control in Controls)
                control.Click += OnClick;
        }
        private MusicMetadata.ArtistCacheItem artist;
        public event Action<MusicMetadata.ArtistCacheItem> ArtistClicked;

        public void SetArtist(MusicMetadata.ArtistCacheItem artistItem)
        {
            artist = artistItem;
            artistTitle.Text = artist.Name;

            if (artistCover.Image != null)
            {
                artistCover.Image.Dispose();
                artistCover.Image = null;

            }

            using var img = Image.FromFile(artist.CoverImagePath);
            artistCover.Image = ImageHelper.ResizeImageKeepAspect(img, artistCover.Size);
        }

        private void OnClick(object? sender, EventArgs e)
        {
            ArtistClicked?.Invoke(artist);
        }
    }
}
