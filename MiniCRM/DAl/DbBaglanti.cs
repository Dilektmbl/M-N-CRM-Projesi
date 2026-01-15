using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace MiniCRM.DAO
{
    public class DbBaglanti
    {
        private static string connStr = "Server=172.21.54.253;Database=26_132430033;User ID = 26_132430046;Pwd=İnif123.;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
