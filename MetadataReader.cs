namespace MusicPlayer
{
    public class SongMetadata
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
    }

    public static class MetadataReader
    {
        public static SongMetadata GetMetadata(string filePath)
        {
            var tagFile = TagLib.File.Create(filePath);

            return new SongMetadata
            {
                Title = tagFile.Tag.Title ?? Path.GetFileNameWithoutExtension(filePath),
                Artist = tagFile.Tag.FirstPerformer ?? "Unknown Artist",
                Album = tagFile.Tag.Album ?? "Unknown Album"
            };
        }
    }

}
