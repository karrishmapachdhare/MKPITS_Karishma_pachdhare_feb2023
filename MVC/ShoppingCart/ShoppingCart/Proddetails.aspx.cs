using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ShoppingCart
{
    public partial class Proddetails : System.Web.UI.Page
    {
        string pid = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            {
                pid = Request.QueryString["Prodid"].ToString();
                binddata();

            }


            
        }
        //user defined function

        public void binddata()

        {

            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string str = "select * from Products where Prodid='" + pid + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Products");

            DataList1.DataSource = ds.Tables["Products"];
            DataList1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //get the button

            Button Button1 = (Button)sender;

            //handle it

            //  Button1.ImageUrl = ...;
            //Get the Parent witch its a DatalistItem in this case

            DataListItem item = (DataListItem)Button1.Parent;
            //find controls in the parent

            Label l = (Label)item.FindControl("lblProdid");
            // Response.Write(lpid.Text);
            string pid = l.Text;

            Label l1 = (Label)item.FindControl("Label1");
            // Response.Write(l.Text);
            string pname = l1.Text;
            Label l2 = (Label)item.FindControl("lblProddescription");
            // Response.Write(l.Text);
            string pdescription = l2.Text;
            Label l3 = (Label)item.FindControl("lblProdImage");
            // Response.Write(l.Text);
            string pimage = l3.Text;
            Label l4 = (Label)item.FindControl("lblProdPrice");
            // Response.Write(l.Text);
            string pprice = l4.Text;
            string sid = Session.SessionID.ToString();
            Session["SessionId"] = sid;
            Response.Write(Session["SessionId"].ToString());

            // Response.Redirect("Proddetails.aspx?prodid=" + pid);
            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string str = null;
            str = "select count(*) from cttable3 where Prodid='" + pid + "' and Sessionid='" + Session["Sessionid"].ToString() + "' ";
            SqlCommand da = new SqlCommand(str, con);
            con.Open();
            int r = Convert.ToInt32(da.ExecuteScalar());
            int qty = 1;
            con.Close();

            if (r == 0)
            {
                str = "insert into cttable3 values('" + pid + "','" + pname + "','" + pdescription + "','" + pprice + "','" + pimage + "','" + Session["SessionId"].ToString() + "'," + qty + ")";
                SqlCommand command = new SqlCommand(str, con);
                con.Open();
                command.ExecuteNonQuery();
                //   Response.Write("saved");
                con.Close();
                Response.Redirect("viewcart.aspx");
            }
            else
            {
                str = "update cttable3 set Quantity=Quantity+1 where Prodid='" + pid + "' and SessionId='" + Session["SessionId"].ToString() + "'";

                SqlCommand command = new SqlCommand(str, con);
                con.Open();
                command.ExecuteNonQuery();
                //   Response.Write("saved");
                con.Close();
                Response.Redirect("viewcart.aspx");

            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewcart.aspx");

        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        //protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
        }
    }

}
    



 
