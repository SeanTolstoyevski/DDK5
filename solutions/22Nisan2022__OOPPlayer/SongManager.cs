namespace Player;

public class SongManager
{
    public SongManager(Song song)
    {
        this.song = song;
    }

    public string GetLastPlayedDateInReadable(ISongEntity song)
    {
        var val = song.LastPlayedDate.ToString("dd MMMM yyyy, dddd");
        return val;
    }

    public void PlaySong(IPlay playable)
    {
        Console.WriteLine("Caliniyor");
        playable.Play(song);
    }

    public Song song { get; set; }
}

