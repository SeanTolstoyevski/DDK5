using System.Collections.Generic;

namespace Player;

public class PlayList : ISongEntity
{


    public string name { get; set; }
    public List<Song> songs { get; set; }
    public int SongCount { get => songs.Count(); }
    public User user { get; set; }
    public DateTime LastPlayedDate { get; set; }

}

