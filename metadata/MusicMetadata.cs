using Newtonsoft.Json;

namespace MusicPlayer.metadata
{
    public class MusicMetadata
    {
        public const string MusicFolderPath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\musicFiles\\";
        private const string ArtistCacheFilePath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\metadata\\jsons\\artistsCache.json";
        private const string AlbumsCacheFilePath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\metadata\\jsons\\albumsCache.json";
        private const string SongsCacheFilePath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\metadata\\jsons\\songsCache.json";

        private Dictionary<string, string> artistIdMap = new();
        private Dictionary<string, string> albumIdMap = new();

        public List<ArtistCacheItem> Artists { get; set; } = new List<ArtistCacheItem>();
        public List<AlbumCacheItem> Albums { get; set; } = new List<AlbumCacheItem>();
        public List<SongCacheItem> Songs { get; set; } = new List<SongCacheItem>();

        public class ArtistCacheItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string CoverImagePath { get; set; }
            public string Genre { get; set; }
        }

        public class AlbumCacheItem
        {
            public string Id { get; set; }
            public string ArtistId { get; set; }
            public string Name { get; set; }
            public string CoverImagePath { get; set; }
            public int Year { get; set; }
        }

        public class SongCacheItem
        {
            public string AlbumId { get; set; }
            public int Track { get; set; }
            public string Title { get; set; }
            public string FilePath { get; set; }
            public string Duration { get; set; }
        }

        public void LoadArtistCache()
        {
            if (File.Exists(ArtistCacheFilePath))
            {
                var json = File.ReadAllText(ArtistCacheFilePath);
                Artists = JsonConvert.DeserializeObject<List<ArtistCacheItem>>(json);
            }
        }

        public void LoadAlbumsCache()
        {
            if (File.Exists(AlbumsCacheFilePath))
            {
                var json = File.ReadAllText(AlbumsCacheFilePath);
                Albums = JsonConvert.DeserializeObject<List<AlbumCacheItem>>(json);
            }
        }

        public void LoadSongsCache()
        {
            if (File.Exists(SongsCacheFilePath))
            {
                var json = File.ReadAllText(SongsCacheFilePath);
                Songs = JsonConvert.DeserializeObject<List<SongCacheItem>>(json);
            }
        }

        public void SaveArtistCache()
        {
            var json = JsonConvert.SerializeObject(Artists, Formatting.Indented);
            File.WriteAllText(ArtistCacheFilePath, json);
        }

        public void SaveAlbumCache()
        {
            var json = JsonConvert.SerializeObject(Albums, Formatting.Indented);
            File.WriteAllText(AlbumsCacheFilePath, json);
        }

        public void SaveSongCache()
        {
            var json = JsonConvert.SerializeObject(Songs, Formatting.Indented);
            File.WriteAllText(SongsCacheFilePath, json);
        }

        public List<ArtistCacheItem> GetArtists()
        {
            return Artists;
        }

        public List<AlbumCacheItem> GetAlbums()
        {
            return Albums;
        }

        public List<SongCacheItem> GetSongs()
        {
            return Songs;
        }

        public void CreateAllCaches()
        {
            CreateArtistCache();
            CreateAlbumCache();
            CreateSongCache();
        }

        public void CreateArtistCache()
        {
            Artists.Clear();
            artistIdMap.Clear();

            var artistDirs = Directory.GetDirectories(MusicFolderPath);

            foreach (var artistDir in artistDirs)
            {
                string artistId = Guid.NewGuid().ToString();
                string artistName = Path.GetFileName(artistDir);
                string artistCover = Path.Combine(artistDir, "artist.jpg");

                string genre = string.Empty;
                var albumDirs = Directory.GetDirectories(artistDir);
                foreach (var albumDir in albumDirs)
                {
                    var musicFiles = Directory.GetFiles(albumDir, "*.mp3");
                    if (musicFiles.Length > 0)
                    {
                        var tag = TagLib.File.Create(musicFiles[0]);
                        genre = tag.Tag.Genres.FirstOrDefault() ?? "";
                        break;
                    }
                }

                Artists.Add(new ArtistCacheItem
                {
                    Id = artistId,
                    Name = artistName,
                    CoverImagePath = File.Exists(artistCover) ? artistCover : string.Empty,
                    Genre = genre
                });

                artistIdMap[artistDir] = artistId;
            }

            SaveArtistCache();
        }

        public void CreateAlbumCache()
        {
            Albums.Clear();
            albumIdMap.Clear();

            var artistDirs = Directory.GetDirectories(MusicFolderPath);

            foreach (var artistDir in artistDirs)
            {
                if (!artistIdMap.ContainsKey(artistDir)) continue;

                var albumDirs = Directory.GetDirectories(artistDir);
                foreach (var albumDir in albumDirs)
                {
                    string albumId = Guid.NewGuid().ToString();
                    string albumName = Path.GetFileName(albumDir);
                    string coverPath = Path.Combine(albumDir, "cover.jpg");

                    int year = 0;
                    var musicFiles = Directory.GetFiles(albumDir, "*.mp3");
                    if (musicFiles.Length > 0)
                    {
                        var tag = TagLib.File.Create(musicFiles[0]);
                        year = (int)tag.Tag.Year;
                    }

                    Albums.Add(new AlbumCacheItem
                    {
                        Id = albumId,
                        ArtistId = artistIdMap[artistDir],
                        Name = albumName,
                        CoverImagePath = File.Exists(coverPath) ? coverPath : string.Empty,
                        Year = year
                    });

                    albumIdMap[albumDir] = albumId;
                }
            }

            SaveAlbumCache();
        }

        public void CreateSongCache()
        {
            Songs.Clear();

            var artistDirs = Directory.GetDirectories(MusicFolderPath);

            foreach (var artistDir in artistDirs)
            {
                var albumDirs = Directory.GetDirectories(artistDir);
                foreach (var albumDir in albumDirs)
                {
                    if (!albumIdMap.ContainsKey(albumDir)) continue;

                    var musicFiles = Directory.GetFiles(albumDir, "*.mp3", SearchOption.TopDirectoryOnly);

                    foreach (var musicFile in musicFiles)
                    {
                        var tagFile = TagLib.File.Create(musicFile);

                        Songs.Add(new SongCacheItem
                        {
                            AlbumId = albumIdMap[albumDir],
                            Track = (int)tagFile.Tag.Track,
                            Title = tagFile.Tag.Title,
                            FilePath = musicFile,
                            Duration = tagFile.Properties.Duration.ToString(@"mm\:ss")
                        });
                    }
                }
            }

            SaveSongCache();
        }
    }
}
