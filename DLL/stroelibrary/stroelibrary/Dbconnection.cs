using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace stroelibrary
{
    internal  static class Dbconnection
    
    {
        public static SqlConnection con;
        public static SqlConnection GetConnection()
        {
            con=new SqlConnection("server=OREO\\SQLEXPRESS ;integrated security=true; database=TrustDB");
            return con;
        }

    }
}
