

namespace singleton;

class Program
{
    static void Main()
    {
        var supManager = new SuplierManager();
        var supLists = supManager.GetAllSupliers();
        foreach (var s in supLists)
            Console.WriteLine("Suplier name : {0}", s.CompanyName);

        var oManager = new OrderManager();
        var orderList = oManager.GetAllOrders();
        foreach (var o in orderList)
            Console.WriteLine("Order : {0} - {1} - Order date : {2}", o.ShipCity, o.ShipCounty, o.OrderDate.ToString());


    } // main block
} // class block
