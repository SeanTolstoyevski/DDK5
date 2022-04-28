using System.Data.SqlClient;

namespace singleton;

public class OrderManager
{
    SingletonConnection sinConn;
    SqlConnection dbConn;
    public OrderManager()
    {
        sinConn = SingletonConnection.getDbInstance();
        dbConn = sinConn.GetDB();
    }

    public List<Order> GetAllOrders()
    {
        var orders = new List<Order>();
        SqlCommand cmd = new SqlCommand("select * from Orders", dbConn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var ord = new Order();
            ord.OrderId = Convert.ToInt32(reader["OrderID"]);
            ord.EmployeeId = Convert.ToInt32(reader["EmployeeID"]);
            ord.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
            ord.RequiredDate = Convert.ToDateTime(reader["RequiredDate"]);
            ord.Freight = Convert.ToDecimal(reader["Freight"]);
            ord.ShipCity = reader["ShipCity"].ToString();
            ord.ShipCounty = reader["ShipCountry"].ToString();
            orders.Add(ord);
        }

        dbConn.Close();
        return orders;
    }


}

