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
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=shoppingcart");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                da = new SqlDataAdapter("select * from Products", con);
                ds = new DataSet();
                da.Fill(ds, "Products");
                DataList1.DataSource = ds.Tables["Products"].DefaultView;
                DataList1.DataBind();
            }
        }
    }
}