using System.Collections.Generic;
using System.Data.SqlClient;

namespace singleton;
public class ProductManager
{
    SingletonConnection sinConn;
    SqlConnection dbConn;
    public ProductManager()
    {
        sinConn = SingletonConnection.getDbInstance();
        dbConn = sinConn.GetDB();
    }

    public List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        SqlCommand cmd = new SqlCommand("select * from Products", dbConn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(reader["ProductId"]);
            product.Name = reader["ProductName"].ToString();
            product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
            product.UnitsInStock = Convert.ToInt32(reader["UnitsInStock"]);
            products.Add(product);
        }
        return products;
    }


}

