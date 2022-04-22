namespace Player;

public class User
{
    public User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    public string name { get; set; }
    public string surname { get; set; }

    public string Email { get; set; }
    public string Password { get => "hashing islemleri"; }
    public string Address { get; set; }


}


