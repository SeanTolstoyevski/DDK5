using System.Collections.Generic;

namespace Player;

public class Album
{
    public List<Song> songs { get; set; }
    public string title { get; set; }
    public int SongCount { get => songs.Count(); }
    public Artist artist { get; set; }
    public string Image { get; set; }

}