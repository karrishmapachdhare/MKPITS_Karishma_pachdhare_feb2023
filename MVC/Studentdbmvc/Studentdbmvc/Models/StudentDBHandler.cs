using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        // 2. ********** Get All Item List **********
        public List<Student> GetItemList()
        {
            connection();
            List<Student> iList = new List<Student>();

            string query = "SELECT * FROM Studentdb";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new Student

                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Address = Convert.ToString(dr[" Address"]),
                    MobNo = Convert.ToInt32(dr["MobNo"]),
                     Email = Convert.ToString(dr["Email"]),
                });
            }
            return iList;
        }

        // 3. ********** Update Item Details **********
        public bool UpdateItem(Student iList)
        {
            connection();
            string query = "UPDATE Studentdb SET Name = '" + iList.Name + "', Address = '" + iList.Address + "' ,MobNo = '" + iList.MobNo + "', Email = " + iList.Email + " WHERE Id = " + iList.Id;
            SqlCommand cmd = new SqlCommand(query, con);
           
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // 4. ********** Delete Item **********
        public bool DeleteItem(int id)
        {
            connection();
            string query = "DELETE FROM ItemList WHERE ID = " + id;
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
