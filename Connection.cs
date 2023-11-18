using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improject
{
    internal class Connection
    {
        private static string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
