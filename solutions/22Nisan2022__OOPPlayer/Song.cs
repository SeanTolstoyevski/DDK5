namespace Player;

public class Song
{
    public Song(string name)
    {
        this.Name = name;
    }


    public string Name { get; set; }
    public DateTime annoDate { get; set; }
    public DateTime ReleaseDate { get => annoDate.AddDays(10); }


}
