using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public static class CourseRegistration
    {
        private static string connectionString = "server=OREO\\SQLEXPRESS;integrated security=true;database=fendal1;";
        //method to create connection
        public static SqlConnection GetSqlConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (Exception ee)
            {
                return null;
            }
        }
        public static DataSet GetNation()
        {
            string query = "select * from TableNation";
            SqlConnection conn = GetSqlConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "TableNation");
            return ds;
        }


        public static DataSet GetState(string NationName)
        {
            string query = "select s.stateid,s.statename from TableState s inner join tablenation n on s.nationid=n.nationid where nationname=@nationname";
            SqlConnection conn = GetSqlConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@nationname",NationName);
            da.Fill(ds, "TableState");
            return ds;
        }

        
        public static DataSet GetCity(string StateName)
        {
            string query = "select c.cityid,c.cityname from TableCity c inner join TableState s on c.stateid=s.stateid where statename=@statename";
            SqlConnection conn = GetSqlConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.SelectCommand.Parameters.AddWithValue("@statename", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }
    }

}

