using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoopingCart1
{
    public partial class Productdetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=shoppingcart");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["Prodid"].ToString();
            // Response.Write(Prodid);

            da = new SqlDataAdapter("select * from Products where Prodid=@Prodid", con);

            da.SelectCommand.Parameters.AddWithValue("@Prodid", prodid); 
            ds = new DataSet();
            da.Fill(ds, "Products");
            DataList1.DataSource = ds.Tables["Products"].DefaultView;
            DataList1.DataBind();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}