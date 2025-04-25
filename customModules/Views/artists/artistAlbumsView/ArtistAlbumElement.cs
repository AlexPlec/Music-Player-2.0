using MusicPlayer.metadata;
using MusicPlayer.utils;

namespace MusicPlayer.customModules.Views.artists.artistAlbumsView
{
    public partial class ArtistAlbumElement : UserControl
    {
        public ArtistAlbumElement()
        {
            InitializeComponent();
            Click += OnClick;
            foreach (Control control in Controls)
                control.Click += OnClick;
        }
        private MusicMetadata.ArtistCacheItem artist;
        private MusicMetadata.AlbumCacheItem album;
        public event Action<MusicMetadata.AlbumCacheItem> AlbumClicked;

        public void SetAlbum(MusicMetadata.AlbumCacheItem albumItem, MusicMetadata.ArtistCacheItem artistItem)
        {
            artist = artistItem;
            album = albumItem;

            artistTitle.Text = artist.Name;
            albumTitle.Text = album.Name;

            if (albumCover.Image != null)
            {
                albumCover.Image.Dispose();
                albumCover.Image = null;
            }

            using var img = Image.FromFile(album.CoverImagePath);
            albumCover.Image = ImageHelper.ResizeImageKeepAspect(img, albumCover.Size);
        }

        private void OnClick(object? sender, EventArgs e)
        {
            AlbumClicked?.Invoke(album);
        }
    }
}
