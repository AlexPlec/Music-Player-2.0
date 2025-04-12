using static MusicPlayer.MusicMetadata;

namespace MusicPlayer
{
    public class MusicLibraryLoader
    {
        private ListBox _artistListBox;
        private ListBox _albumListBox;
        private ListBox _songListBox;
        private List<Artist> _artists;

        public MusicLibraryLoader(ListBox artistListBox, ListBox albumListBox, ListBox songListBox)
        {
            _artistListBox = artistListBox;
            _albumListBox = albumListBox;
            _songListBox = songListBox;
        }

        public void LoadLibrary(List<Artist> artists)
        {
            _artists = artists;
            _artistListBox.Items.Clear();

            foreach (var artist in _artists)
            {
                _artistListBox.Items.Add(artist.Name);
            }

            _artistListBox.SelectedIndexChanged += ArtistSelected;
        }

        private void ArtistSelected(object sender, System.EventArgs e)
        {
            int artistIndex = _artistListBox.SelectedIndex;
            if (artistIndex < 0 || artistIndex >= _artists.Count)
                return;

            var selectedArtist = _artists[artistIndex];
            _albumListBox.Items.Clear();
            _songListBox.Items.Clear();

            foreach (var album in selectedArtist.Albums)
            {
                _albumListBox.Items.Add(album.Name);
            }

            _albumListBox.SelectedIndexChanged += (s, args) =>
            {
                int albumIndex = _albumListBox.SelectedIndex;
                if (albumIndex < 0 || albumIndex >= selectedArtist.Albums.Count)
                    return;

                var selectedAlbum = selectedArtist.Albums[albumIndex];
                _songListBox.Items.Clear();

                foreach (var song in selectedAlbum.Songs)
                {
                    //     _songListBox.Items.Add($"{song.Track}. {song.Title}");
                    _songListBox.Items.Add(new SongListItem(song));
                }
            };
        }
    }
}
