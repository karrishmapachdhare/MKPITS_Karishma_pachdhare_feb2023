using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeedetails
{
    public static class EmployeeDetails
    {
        //creating a static variable
        private static string connectionString = "server=.OREO\\SQLEXPRESS;integrated security=true;database=mkp";
        //creating a static method
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
        //method to return city name 
        public static SqlDataReader GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                //sqldatareader is used to store record returned from city table
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }

        }

    }
}

