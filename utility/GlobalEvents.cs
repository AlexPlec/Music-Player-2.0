using MusicPlayer.metadata;

namespace MusicPlayer.utility
{
    public static class GlobalEvents
    {
        public static event Action<MusicMetadata.ArtistCacheItem, MusicMetadata.AlbumCacheItem, MusicMetadata.SongCacheItem, List<MusicMetadata.SongCacheItem>> SongSelected;

        public static void FireSongSelected(MusicMetadata.ArtistCacheItem artist, MusicMetadata.AlbumCacheItem album, MusicMetadata.SongCacheItem song, List<MusicMetadata.SongCacheItem> songList)
        {
            SongSelected?.Invoke(artist, album, song, songList);
        }

        public static MusicMetadata.SongCacheItem CurrentSong { get; set; }
    }
}
