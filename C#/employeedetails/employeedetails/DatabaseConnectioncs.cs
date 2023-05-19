using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeedetails
{
    public static class DatabaseConnectioncs
    {

        //creating a static variable
        private static string connectionstring = "server=OREO\\SQLEXPRESS;integrated security=true;database=mkp";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }  //creating a static method to insert record into users table
        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into users2 values(@username,@password)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
            //creating a static method to update record into users table
            public static string UpdateUser(string username, string password)
            {
                SqlConnection con = GetConnection();
                //creating a insert command
                string query = "update users2 set password=@password where username=@username";
                //@username and @password are sqlparameters
                try
                {
                    //creating an object of sqlcommand class
                    SqlCommand command = new SqlCommand(query, con);
                    //defining sqlparameters

                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@username", username);
                    //executing the command using executenonquery method
                    command.ExecuteNonQuery();
                    return "record updated successfully";
                }
                catch (Exception ee)
                {
                    return ee.ToString();
                }
                finally
                {
                    con.Close();
                }

            }
            //creating a static method to delete record from users table
            public static string DeleteUser(string username)
            {
                SqlConnection con = GetConnection();
                //creating a insert command
                string query = "delete from users2  where username=@username";
                //@username and @password are sqlparameters
                try
                {
                    //creating an object of sqlcommand class
                    SqlCommand command = new SqlCommand(query, con);
                    //defining sqlparameters


                    command.Parameters.AddWithValue("@username", username);
                    //executing the command using executenonquery method
                    command.ExecuteNonQuery();
                    return "record deleted successfully";
                }
                catch (Exception ee)
                {
                    return ee.ToString();
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }




    

