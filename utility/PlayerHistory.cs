using Newtonsoft.Json;
using static MusicPlayer.metadata.MusicMetadata;

namespace MusicPlayer.utility
{
    public class PlayerHistory
    {
        public class HistoryItem
        {
            public List<SongCacheItem> Playlist { get; set; }
            public AlbumCacheItem Album { get; set; }
            public ArtistCacheItem Artist { get; set; }
            public SongCacheItem Song { get; set; }
            public int CurrentIndex { get; set; }
            public double TrackPositionSeconds { get; set; }
            public float Volume { get; set; }
            public string RepeatMode { get; set; }
        }

        private const string HistoryPath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\metadata\\jsons\\history.json";
        public static void Save(HistoryItem history)
        {
            var json = JsonConvert.SerializeObject(history, Formatting.Indented);
            File.WriteAllText(HistoryPath, json);
        }

        public static HistoryItem? Load()
        {
            if (!File.Exists(HistoryPath)) return null;

            var json = File.ReadAllText(HistoryPath);
            return JsonConvert.DeserializeObject<HistoryItem>(json);
        }
    }
}
