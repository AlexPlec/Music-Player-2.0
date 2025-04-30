using MusicPlayer.metadata;
using MusicPlayer.utils;

namespace MusicPlayer.customModules.AudioPlayer
{
    public partial class SongInfoElement : UserControl
    {
        private MusicMetadata.ArtistCacheItem currentArtist;
        private MusicMetadata.AlbumCacheItem currentAlbum;
        public SongInfoElement()
        {
            InitializeComponent();

        }
        public void SetSongInfo(MusicMetadata.ArtistCacheItem artistItem, MusicMetadata.AlbumCacheItem albumItem, MusicMetadata.SongCacheItem songItem)
        {
            if (currentArtist != artistItem)
            {
                artistTitle.Text = artistItem.Name;
                currentArtist = artistItem;
            }

            if (currentAlbum != albumItem)
            {

                albumTitle.Text = albumItem.Name;
                currentAlbum = albumItem;

                if (albumCover.Image != null)
                {
                    albumCover.Image.Dispose();
                    albumCover.Image = null;
                }
                using var img = Image.FromFile(albumItem.CoverImagePath);
                albumCover.Image = ImageHelper.ResizeImageKeepAspect(img, albumCover.Size);
            }

            songTitle.Text = songItem.Title;
        }
    }
}
