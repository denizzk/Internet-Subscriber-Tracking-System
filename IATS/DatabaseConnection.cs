using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IATS
{
    class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnString());            
        }

        public static string GetConnString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
        }

    }
}
