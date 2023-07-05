using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Itemlistmvcdb.Models
{
    public class itemdbhandler
    {

        SqlConnection con = null;
        public void connection()
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            //string constr = "server=OREO\\SQLEXPRESS;integrated security=true;database=compshopdbwithoutef";

            con = new SqlConnection(constr);

        }

        // insert itemmethod to insert record into itemlist table
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "insert into itemlist values('" + ilist.Name + "','" + ilist.Category + "'," + ilist.Price + ")";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 2. ********** Get All Item List **********
        //list generic class to create collection of itemmodel objects
        public List<ItemModel> GetItemList()
        {
            connection();

            List<ItemModel> iList = new List<ItemModel>();

            string query = "SELECT * FROM ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }
        // 3. ********** Update Item Details **********
        public bool UpdateItem(ItemModel iList)
        {
            connection();
            string query = "UPDATE ItemList SET Name = '" + iList.Name + "', Category = '" + iList.Category + "', Price = "+iList.Price+" WHERE ID = "+iList.ID;
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