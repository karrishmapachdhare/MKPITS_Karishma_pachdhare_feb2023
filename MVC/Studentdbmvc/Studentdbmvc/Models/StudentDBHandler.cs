using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Studentdbmvc.Models
{
    public class StudentDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            con = new SqlConnection(constring);
        }
        //1.*******************Insert Student************************
        public bool InsertStudent(Student iList)
        {
            connection();
            string query = "UPDATE Studentdb SET Name = '" + iList.Name + "', Address = '" + iList.Address+"' ,MobNo = '" + iList.MobNo + "', Email = " + iList.Email + " WHERE Id = " + iList.Id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}