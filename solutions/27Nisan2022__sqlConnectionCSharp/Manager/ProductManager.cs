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


        public List<Product> GetMinMaxProducts(decimal min, decimal max)
        {
                        List<Product> products = new List<Product>();

            SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString);
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Products where UnitPrice > @minPrice and UnitPrice < @maxPrice", sqlConnection);
                cmd.Parameters.AddWithValue("@minPrice", min);
                cmd.Parameters.AddWithValue("@maxPrice", max);
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

        public List<Product> GetStockZero()
        {
                        List<Product> products = new List<Product>();

            SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString);
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Products where UnitsInStock = 0", sqlConnection);
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



        public List<Product> SearchName(string name)
        {
                        List<Product> products = new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString);
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Products where ProductName like '%" + name + "%'", sqlConnection);

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

    }
}

