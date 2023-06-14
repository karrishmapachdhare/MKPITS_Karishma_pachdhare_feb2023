using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trustdbstoremangement
{
    public partial class Transcation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=TrustDB");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        public void loaddata()
        {
            str = "select *from Item_master1";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Item_master1");
            GridView1.DataSource = ds.Tables["Item_master1"].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}