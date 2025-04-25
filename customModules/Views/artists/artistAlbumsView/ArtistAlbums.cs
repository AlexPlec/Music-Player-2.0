using MusicPlayer.metadata;

namespace MusicPlayer.customModules.Views.artists.artistAlbumsView
{
    public partial class ArtistAlbums : UserControl
    {
        public ArtistAlbums()
        {
            InitializeComponent();
        }

        public event Action<MusicMetadata.AlbumCacheItem> AlbumSelected;

        public void SetAlbums(List<MusicMetadata.AlbumCacheItem> albumList, MusicMetadata.ArtistCacheItem artistItem)
        {
            artistAlbumsLayout.Controls.Clear();

            foreach (var album in albumList)
            {
                var albumElement = new ArtistAlbumElement();
                albumElement.SetAlbum(album, artistItem);
                albumElement.AlbumClicked += selectedAlbum =>
                {
                    AlbumSelected?.Invoke(selectedAlbum);
                };
                artistAlbumsLayout.Controls.Add(albumElement);
            }
        }
    }
}
