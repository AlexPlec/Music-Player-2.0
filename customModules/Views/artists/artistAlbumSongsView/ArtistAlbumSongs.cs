using MusicPlayer.metadata;
using MusicPlayer.utils;

namespace MusicPlayer.customModules.Views.artists.artistAlbumSongsView
{
    public partial class ArtistAlbumSongs : UserControl
    {
        public ArtistAlbumSongs()
        {
            InitializeComponent();
        }

        public void SetSongs(MusicMetadata.AlbumCacheItem albumItem, MusicMetadata.ArtistCacheItem artistItem, List<MusicMetadata.SongCacheItem> songList)
        {
            songsLayout.Controls.Clear();

            foreach (var song in songList)
            {
                var songElement = new ArtistAlbumSongElement();
                songElement.SetSong(albumItem, artistItem, song);
                songsLayout.Controls.Add(songElement);
            }

            if (albumCover.Image != null)
            {
                albumCover.Image.Dispose();
                albumCover.Image = null;
            }

            using var img = Image.FromFile(albumItem.CoverImagePath);
            albumCover.Image = ImageHelper.ResizeImageKeepAspect(img, albumCover.Size);

            albumTitle.Text = albumItem.Name;
            artistTitle.Text = artistItem.Name;
        }
    }
}
