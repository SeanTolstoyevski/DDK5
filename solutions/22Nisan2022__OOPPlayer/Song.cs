namespace Player;

public class Song : IPlay, ISongEntity
{
    public Song(string name)
    {
        this.Name = name;
    }

    public void Play(Song song)
    {
        Console.WriteLine("dum tis tek tis tis fis fis");
    }


    public DateTime LastPlayedDate { get; set; }
    public string Name { get; set; }
    public DateTime annoDate { get; set; }
    public DateTime ReleaseDate { get => annoDate.AddDays(10); }
    public Artist artist { get; set; }


}


