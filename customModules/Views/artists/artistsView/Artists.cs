using MusicPlayer.metadata;

namespace MusicPlayer.customModules.Views.artists.artistsView
{
    public partial class Artists : UserControl
    {
        public event Action<MusicMetadata.ArtistCacheItem> ArtistSelected;

        public Artists()
        {
            InitializeComponent();
        }
        public void SetArtists(List<MusicMetadata.ArtistCacheItem> artistList)
        {
            ArtistViewLayout.Controls.Clear();

            foreach (var artist in artistList)
            {
                var artistElement = new ArtistElement();
                artistElement.SetArtist(artist);
                artistElement.ArtistClicked += selectedArtist =>
                {
                    ArtistSelected?.Invoke(selectedArtist);
                };
                ArtistViewLayout.Controls.Add(artistElement);
            }
        }

    }
}
