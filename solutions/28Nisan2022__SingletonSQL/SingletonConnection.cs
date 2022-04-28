using System.Data.SqlClient;

namespace singleton;

public class SingletonConnection
{
    private static SingletonConnection dbInstance;
    private readonly SqlConnection sqlConnection = new SqlConnection(CInfo.connectionString);
    private SingletonConnection()
    {

    }


    public static SingletonConnection getDbInstance()
    {
        if (dbInstance == null)
        {
            dbInstance = new SingletonConnection();
        }
        return dbInstance;
    }

    public SqlConnection GetDB()
    {
        sqlConnection.Open();
        return sqlConnection;
    }


} // SingletonConnection class block



