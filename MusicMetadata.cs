using Newtonsoft.Json;

namespace MusicPlayer
{
    public class MusicMetadata
    {

        public class Artist
        {
            public string Name { get; set; }
            public string CoverImagePath { get; set; }
            public List<Album> Albums { get; set; } = new List<Album>();
        }

        public class Album
        {
            public string Name { get; set; }
            public string CoverImagePath { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }
            public List<Song> Songs { get; set; } = new List<Song>();
        }

        public class Song
        {
            public string Title { get; set; }
            public int Track { get; set; }
            public string FilePath { get; set; }
        }

        public const string MusicFolderPath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\musicFiles\\";
        private const string CacheFilePath = "C:\\Users\\accht\\Documents\\GitHub\\Music-Player-2.0\\structuredSongsCache.json";

        public List<Artist> Artists { get; set; } = new List<Artist>();

        public void LoadCache()
        {
            if (File.Exists(CacheFilePath))
            {
                var json = File.ReadAllText(CacheFilePath);
                Artists = JsonConvert.DeserializeObject<List<Artist>>(json);
            }
        }

        public void SaveCache()
        {
            var json = JsonConvert.SerializeObject(Artists, Formatting.Indented);
            File.WriteAllText(CacheFilePath, json);
        }

        public void LoadMetada()
        {
            var directories = Directory.GetDirectories(MusicFolderPath);

            foreach (var artistDir in directories)
            {
                string artistName = Path.GetFileName(artistDir);
                string artistCoverPath = Path.Combine(artistDir, "artist.jpg");


                var artist = new Artist
                {
                    Name = artistName,
                    CoverImagePath = File.Exists(artistCoverPath) ? artistCoverPath : string.Empty
                };



                var albumDirectories = Directory.GetDirectories(artistDir);

                foreach (var albumDir in albumDirectories)
                {
                    string albumName = Path.GetFileName(albumDir);
                    string albumCoverPath = Path.Combine(albumDir, "cover.jpg");

                    var album = new Album
                    {
                        Name = albumName,
                        CoverImagePath = File.Exists(albumCoverPath) ? albumCoverPath : string.Empty
                    };

                    var musicFiles = Directory.GetFiles(albumDir, "*.mp3", SearchOption.TopDirectoryOnly);

                    foreach (var musicFile in musicFiles)
                    {
                        var tagFile = TagLib.File.Create(musicFile);
                        var song = new Song
                        {
                            Title = tagFile.Tag.Title,
                            Track = (int)tagFile.Tag.Track,
                            FilePath = musicFile
                        };
                        album.Songs.Add(song);
                    }

                    if (album.Songs.Count > 0)
                    {
                        var tagFile = TagLib.File.Create(album.Songs[0].FilePath);
                        album.Genre = tagFile.Tag.Genres.FirstOrDefault();
                        album.Year = (int)tagFile.Tag.Year;
                    }

                    artist.Albums.Add(album);
                }
                Artists.Add(artist);
            }
        }

        public List<Artist> GetAllArtists()
        {
            return Artists;
        }

    }
}
