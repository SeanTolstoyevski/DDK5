using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SQLWorking.Models;

namespace SQLWorking.Manager
{
    public class ProductManager
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString))
            {

                try
                {
                    sqlConnection.Open();


                    SqlCommand cmd = new SqlCommand("select * from Products", sqlConnection);

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


                    sqlConnection.Close();

                    return products;
                }
                catch (Exception ex)
                {
                    return products;
                }

            }
        }
    }
}