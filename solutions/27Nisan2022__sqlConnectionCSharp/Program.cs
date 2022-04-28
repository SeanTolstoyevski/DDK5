using SQLWorking.Manager;



namespace SQLWorking;

class program
{
    static void Main()
    {
        var pManager = new ProductManager();
var minMaxProducts = pManager .GetMinMaxProducts(5M, 25M);
        foreach(var p in minMaxProducts)
            Console.WriteLine("{0}, - {1}", p.Name, p.UnitPrice);
        
        var zeroStocksProducts = pManager.GetStockZero();
        foreach(var p in zeroStocksProducts)
            Console.WriteLine("Zero Stock : {0}, - {1}", p.Name, p.UnitPrice);


        Console.WriteLine("aramak istediginiz urun:");
        string searchName = Console.ReadLine();
        var searchedResults = pManager.SearchName(searchName);
        foreach(var p in searchedResults)
            Console.WriteLine("Name search: {0}", p.Name);

        



    } // main block



}