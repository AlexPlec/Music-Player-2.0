using MusicPlayer.metadata;

namespace MusicPlayer.customModules.Views.artists.artistAlbumSongsView
{
    public partial class ArtistAlbumSongElement : UserControl
    {
        public ArtistAlbumSongElement()
        {
            InitializeComponent();
        }
        public void SetSong(MusicMetadata.AlbumCacheItem albumItem, MusicMetadata.ArtistCacheItem artistItem, MusicMetadata.SongCacheItem songItem)
        {
            artistTitle.Text = artistItem.Name;
            albumTitle.Text = albumItem.Name;
            songNumber.Text = songItem.Track.ToString();
            songTitle.Text = songItem.Title;
            songDuration.Text = songItem.Duration;
        }
    }
}