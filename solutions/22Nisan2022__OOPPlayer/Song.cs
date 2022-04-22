namespace Player;

public class Song : IPlay
{
    public Song(string name)
    {
        this.Name = name;
    }

    public void Play(Song song)
    {
        Console.WriteLine("Caliniyor: {0}", song.Name);
    }


    public string Name { get; set; }    
    public DateTime annoDate { get; set; }
    public DateTime ReleaseDate { get => annoDate.AddDays(10); }
    public Artist artist { get; set; }


}


