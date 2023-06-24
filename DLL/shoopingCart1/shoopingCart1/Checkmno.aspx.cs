using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoopingCart1
{
    public partial class Checkmno : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=shoppingcart");
        SqlCommand command;
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["Prodid"]);
            Response.Write("Prodid " + prodid);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string ProdName = null;
            int ProdPrice = 0;
            int Qty = 0;
            string sessionid = null;
            if (res == "123456")
            {
                query = "select * from Products where Prodid=@prodid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Prodid", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ProdName = dr["prodname"].ToString();
                    ProdPrice = Convert.ToInt32(dr["prodprice"].ToString());

                    Qty = 1;
                    sessionid = Session.SessionID;

                }
                con.Close();
                Response.Write("ProdName " + ProdName + "<br>");
                Response.Write("Prod Price " + ProdPrice + "<br>");
                Response.Write("Qty " + Qty + "<br>");
                Response.Write("Session id " + sessionid + "<br>");
                //save the product data into carttable

                // Response.Redirect("cart1.aspx");
            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
    
}