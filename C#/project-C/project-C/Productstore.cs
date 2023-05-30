using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace project_C
{
    public static class Productstore
    {
        private static string connectionstring = "server=OREO\\SQLEXPRESS ;integrated security =true;database=Project-c;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                //conn.open();
                return conn;
            
           
            }
        }

    }

}


        





    
    
            

    

