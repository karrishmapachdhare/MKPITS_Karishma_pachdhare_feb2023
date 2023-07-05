using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace connectionmvc.Models
{
    public class Itemdbhandlarcs
    {
        SqlConnection con = null;
        public void connection()
        {
            // string constr= System.Configuration.ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=OREO\\SQLEXPRESS;integrated security=true;database=Itemlist";
            con = new SqlConnection(constr);
        }
        //insert itemmethod to insert record into itemlist table
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "insert into Itemlist values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Prices + "')";
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

    }

}
