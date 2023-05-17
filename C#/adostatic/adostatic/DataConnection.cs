using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adostatic
{
    internal class DatabaseConnection
    {
        //creating a static variable
        private static string connectionstring = "server=.OREO\\SQLEXPRESS;integrated security = true;Database=ladcolg;";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException  ee ) 
            {
                return null;
            }
        }
    }  
}
