

namespace singleton;

class Program
{
    static void Main()
    {
        var supManager = new SuplierManager();
        var supLists = supManager.GetAllSupliers();
        foreach(var s in supLists)
            Console.WriteLine("Suplier name : {0}", s.CompanyName);


        

    } // main block
} // class block
