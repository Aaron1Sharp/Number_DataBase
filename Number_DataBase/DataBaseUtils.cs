using MySql.Data.MySqlClient;

namespace Number_DataBase
{
    class DataBaseUtils
    {
      public static  MySqlConnection GetMySqlConnection()
        {
            string host     = "localhost";
            int    port     = 3306;
            string database = "number";
            string username = "root";
            string password = "root";
            return DataBaseMySqlUtils.GetMySqlConnection(host, port, database, username, password);
        } 
    }
}
