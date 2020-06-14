using MySql.Data.MySqlClient;

namespace Number_DataBase
{
    class DataBaseMySqlUtils
    {
        public static MySqlConnection GetMySqlConnection(string host, int port, string database, string username, string password)
        {
            string connString = "Server=" + host + ";Database=" + database + 
            ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection _connection = new MySqlConnection(connString);
            return _connection;
        }
    }
}
