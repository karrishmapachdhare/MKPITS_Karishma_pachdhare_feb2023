using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseregister
{
    public static class courseregistration

    {
        private static string connectionString = "server=OREO\\SQLEXPRESS;integrated security=true;database=worlddata;";
        //method to create connection
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //conn.Open();
                return conn;
            }
            catch (Exception ee)
            {
                return null;
            }
            

            
            
        }
        public static DataSet GetCountry()
        {
            string query = "select Country from sheet1$";
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "Sheet1$");
            return ds;
        }

    }
}
