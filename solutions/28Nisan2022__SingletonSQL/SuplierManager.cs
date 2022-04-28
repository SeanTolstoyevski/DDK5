using System.Data.SqlClient;

namespace singleton;

public class SuplierManager
{
    public SingletonConnection single2;
    SqlConnection dbConn;

    public SuplierManager()
    {
        single2 = SingletonConnection.getDbInstance();
        dbConn = single2.GetDB();
    }

    public List<Suplier> GetAllSupliers()
    {
        List<Suplier> supliers = new List<Suplier>();
        var cmd = new SqlCommand("select * from Suppliers", dbConn);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Suplier suplier = new Suplier();
            suplier.Id = Convert.ToInt32(reader["SupplierID"]);
            suplier.CompanyName = reader["CompanyName"].ToString();
            suplier.ContactName = reader["ContactName"].ToString();
            supliers.Add(suplier);
        }

        return supliers;
    }




}



