namespace Player;

public class Artist
{
    public Artist(string name, string Surname)
    {
        this.name = name;
        this.Surname = Surname;
    }

    public string name { get; set; }
    public string Surname { get; set; }
    public string Country { get; set; }
    public DateTime BirthDate { get; set; }
}