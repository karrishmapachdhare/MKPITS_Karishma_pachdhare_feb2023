using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace connectionItem.Models
{
    public class ItemDBhandler
    {
        private SqlConnection con;
        private void connection()
        {
            // string constring = ConfigurationManager.connectionstrings["Itemlist"].ToString();
            // con =new SqlConnection(constring);
            string constr = "server=OREO\\SQLEXPRESS;integrated security=true;database=Itemlist";
            con=new SqlConnection(constr);

        }
        //2**********************Get All Item List*****************************
        //list generic class to create collection of itemmodel objects
        public List<ItemModel> GetItemList()
        {
            connection();
            List<ItemModel> iList = new List<ItemModel>();
            string query = "selcet* from Itemlist";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }
        // 1. ********** Insert Item **********
        public bool InsertItem(ItemModel iList)
        {
            connection();
            string query = "INSERT INTO ItemList VALUES('" + iList.Name + "','" + iList.Category + "'," + iList.Price + ")";
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