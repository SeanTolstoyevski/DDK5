namespace CsharpTypes;

class Program
{
    static void Main()
    {
        ILog l = new Ex();
        ILog l1 = new DB();
        var al = new Logger();
        al.ApplyLog(l);
        al.ApplyLog(l1);
    }
}

