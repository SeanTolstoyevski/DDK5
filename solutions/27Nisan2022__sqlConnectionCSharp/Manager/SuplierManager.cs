using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SQLWorking.Models;

namespace SQLWorking.Manager
{
    public class SuplierManager
    {
        public List<Suplier> GetAllSupliers()
        {
            List<Suplier> supliers = new List<Suplier>();

            using (SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString))
            {

                try
                {
                    sqlConnection.Open();

                    SqlCommand cmd = new SqlCommand("select * from Supliers", sqlConnection);

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Suplier suplier = new Suplier();

                        suplier.Id = Convert.ToInt32(reader["SuplierId"]);
                        suplier.CompanyName = reader["CompanyName"].ToString();
                        suplier.ContactName = reader["ContactName"].ToString();

                        supliers.Add(suplier);

                    }

                    sqlConnection.Close();
                    return supliers;
                }
                catch (Exception ex)
                {
                    return supliers;
                }

            }
        }
    }
}


