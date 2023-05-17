﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconnectionx
{
    public static class DatabaseConnection
    {
        //creating a static variable

        private static string connectionString = "server=.OREO\\SQLEXPRESS;integrated security=true;database=orders";
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
        //creating a static method to insert record into user table
        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into user values(@username,@password)";
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
    }
}
