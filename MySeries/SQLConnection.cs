using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL
{
    public class SQLConnection
    {
        private static string connectionString = "Server=DaniBit;Database=MySeries;Trusted_Connection=True;";
        private static SqlConnection connection;

        public static void open()
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
        }

        public static void close()
        {
            connection.Close();
            connection = null;
        }

        public static int ExecuteNonQuery(string sqlStatement) 
        {
            using (SqlCommand command = new SqlCommand(sqlStatement, connection))
            {
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sqlStatement)
        {
            using (SqlCommand command = new SqlCommand(sqlStatement, connection))
            {
                return command.ExecuteScalar();
            }
        }

        public static SqlDataReader ExecuteReader(string sqlStatement)
        {
            SqlCommand command = new SqlCommand(sqlStatement, connection);
            return command.ExecuteReader();
        }
    }
}
