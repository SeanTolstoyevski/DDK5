using System.Collections.Generic;

namespace Player;

public class Group
{
    public Group(string name)
    {
        this.name = name;
    }


    public string name { get; set; }
    public List<Artist> artists { get; set; }
    public DateTime EstablishDate { get; set; }

}



