using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace ado.net1
{
    internal class databaseconnection
    {

        //creating a static variable
        private static string connectionString = "server=.OREO\\SQLEXPRESS;integrated security=true;database=customer;";
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
                    
            }
            catch (SqlException ee)
            {
                return null;

            }
        }
    }
}
