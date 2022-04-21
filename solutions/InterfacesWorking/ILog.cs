namespace CsharpTypes;

public interface ILog
{
    void Log(string log);
}

class Ex : ILog
{
    public void Log(string x)
    {
        Console.WriteLine("Excel : {0}", x);
    }
}


class DB : ILog
{
    public void Log(string x)
    {
        Console.WriteLine("Database : {0}", x);
    }
}

