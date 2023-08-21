using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Banco.ADO
{
    public class Connection
    {
        public static MySqlConnection conn = null;

        static string server = "127.0.0.1;";
        static string database = "bancodb;";
        static string uId = "root;";
        static string password = ";";

        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                conn = new MySqlConnection($"server={server} database={database} Uid={uId} password={password}");
            }
            return conn;
        }

        public static void closeConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
