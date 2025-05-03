namespace MusicPlayer.customModules.AudioPlayer;

public partial class ButtonsElement : UserControl
{
    private AudioPlayer audioPlayer;
    public Button BtnPlay => btnPlay;
    public enum RepeatMode
    {
        RepeatOff,
        RepeatSong,
        RepeatAlbum
    }
    public RepeatMode repeatMode = RepeatMode.RepeatOff;
    public ButtonsElement()
    {
        InitializeComponent();
        btnRepeat.Click += OnRepeatClicked;
        btnPrevious.Click += OnPreviousClicked;
        btnNext.Click += OnNextClicked;
        btnPlay.Click += OnPlayClicked;
    }
    public void TogglePlay()
    {
        btnPlay.PerformClick();
    }
    public void NextTrack()
    {
        btnNext.PerformClick();
    }
    public void PreviousTrack()
    {
        btnPrevious.PerformClick();
    }
    public void SetAudioPlayer(AudioPlayer player)
    {
        audioPlayer = player;
    }
    private void OnPlayClicked(object? sender, EventArgs e)
    {
        if (audioPlayer.isPlaying)
        {
            audioPlayer.outputDevice?.Stop();
            btnPlay.Text = "Stop";
        }
        else
        {
            audioPlayer.outputDevice?.Play();
            btnPlay.Text = "Play";
        }

        audioPlayer.isPlaying = !audioPlayer.isPlaying;
    }
    private void OnRepeatClicked(object? sender, EventArgs e)
    {
        switch (repeatMode)
        {
            case RepeatMode.RepeatOff:
                repeatMode = RepeatMode.RepeatSong;
                btnRepeat.Text = "Repeat S";
                break;
            case RepeatMode.RepeatSong:
                repeatMode = RepeatMode.RepeatAlbum;
                btnRepeat.Text = "Repeat A";
                break;
            case RepeatMode.RepeatAlbum:
                repeatMode = RepeatMode.RepeatOff;
                btnRepeat.Text = "Repeat Off";
                break;
        }
    }
    public void UpdateRepeatButtonText()
    {
        switch (repeatMode)
        {
            case RepeatMode.RepeatOff:
                btnRepeat.Text = "Repeat Off";
                break;
            case RepeatMode.RepeatSong:
                btnRepeat.Text = "Repeat S";
                break;
            case RepeatMode.RepeatAlbum:
                btnRepeat.Text = "Repeat A";
                break;
        }
    }
    private void OnPreviousClicked(object? sender, EventArgs e)
    {

        if (audioPlayer.currentAlbumSongs == null || audioPlayer.currentSong == null)
            return;

        int currentIndex = audioPlayer.currentAlbumSongs.IndexOf(audioPlayer.currentSong);
        if (currentIndex > 0)
        {
            var previousSong = audioPlayer.currentAlbumSongs[currentIndex - 1];
            audioPlayer.LoadSong(audioPlayer.currentArtist, audioPlayer.currentAlbum, previousSong, audioPlayer.currentAlbumSongs);
        }
        else
        {
            audioPlayer.LoadSong(audioPlayer.currentArtist, audioPlayer.currentAlbum, audioPlayer.currentAlbumSongs[^1], audioPlayer.currentAlbumSongs);
        }
        btnPlay.Text = "Play";
        audioPlayer.isPlaying = true;
    }
    private void OnNextClicked(object? sender, EventArgs e)
    {
        if (audioPlayer.currentAlbumSongs == null || audioPlayer.currentSong == null)
            return;

        int currentIndex = audioPlayer.currentAlbumSongs.IndexOf(audioPlayer.currentSong);
        if (currentIndex >= 0 && currentIndex < audioPlayer.currentAlbumSongs.Count - 1)
        {
            var nextSong = audioPlayer.currentAlbumSongs[currentIndex + 1];
            audioPlayer.LoadSong(audioPlayer.currentArtist, audioPlayer.currentAlbum, nextSong, audioPlayer.currentAlbumSongs);
        }
        else
        {

            audioPlayer.LoadSong(audioPlayer.currentArtist, audioPlayer.currentAlbum, audioPlayer.currentAlbumSongs[0], audioPlayer.currentAlbumSongs);
        }
        btnPlay.Text = "Play";
        audioPlayer.isPlaying = true;
    }
}
