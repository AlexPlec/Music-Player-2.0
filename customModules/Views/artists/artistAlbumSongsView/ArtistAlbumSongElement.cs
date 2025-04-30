using MusicPlayer.metadata;
using MusicPlayer.utility;

namespace MusicPlayer.customModules.Views.artists.artistAlbumSongsView
{
    public partial class ArtistAlbumSongElement : UserControl
    {
        private MusicMetadata.ArtistCacheItem artist;
        private MusicMetadata.AlbumCacheItem album;
        private MusicMetadata.SongCacheItem song;
        private List<MusicMetadata.SongCacheItem> songs;
        public ArtistAlbumSongElement()
        {
            InitializeComponent();
            Click += ArtistAlbumSongElement_Click;
            foreach (Control control in Controls)
                control.Click += ArtistAlbumSongElement_Click;
        }
        public void SetSong(MusicMetadata.AlbumCacheItem albumItem, MusicMetadata.ArtistCacheItem artistItem, MusicMetadata.SongCacheItem songItem, List<MusicMetadata.SongCacheItem> songList)
        {
            artist = artistItem;
            album = albumItem;
            song = songItem;
            songs = songList;

            artistTitle.Text = artistItem.Name;
            albumTitle.Text = albumItem.Name;
            songNumber.Text = songItem.Track.ToString();
            songTitle.Text = songItem.Title;
            songDuration.Text = songItem.Duration;
        }
        private void ArtistAlbumSongElement_Click(object sender, EventArgs e)
        {
            GlobalEvents.FireSongSelected(artist, album, song, songs);
            GlobalEvents.CurrentSong = song;
        }
    }
}