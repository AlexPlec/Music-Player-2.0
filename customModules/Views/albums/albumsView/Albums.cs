using MusicPlayer.metadata;

namespace MusicPlayer.customModules.Views.albums.albumsView
{
    public partial class Albums : UserControl
    {
        public Albums()
        {
            InitializeComponent();
        }

        public event Action<MusicMetadata.AlbumCacheItem> AlbumSelected;

        public void SetAlbums(List<MusicMetadata.AlbumCacheItem> albumList, List<MusicMetadata.ArtistCacheItem> artistList)
        {
            albumsLayout.Controls.Clear();

            foreach (var album in albumList)
            {
                var artist = artistList.FirstOrDefault(a => a.Id == album.ArtistId);
                if (artist == null) continue; // skip if artist not found

                var albumElement = new AlbumElement();
                albumElement.SetAlbum(album, artist);
                albumElement.AlbumClicked += selectedAlbum =>
                {
                    AlbumSelected?.Invoke(selectedAlbum);
                };
                albumsLayout.Controls.Add(albumElement);
            }
        }
    }
}
