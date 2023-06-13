using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace trustdbstoremangement
{
    public partial class ItenEntry : System.Web.UI.Page
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
            loaddata();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_master1 values(@Item_name,@Categroy,@Rate,@Balance_quantity)";
            SqlCommand command = new SqlCommand(str, con);

            //command.Parameters.AddWithValue("@item_id", (TextBox4.Text));

            command.Parameters.AddWithValue("@Item_name",(TextBox1.Text));
            command.Parameters.AddWithValue("@Categroy", (DropDownList1.Text));
            command.Parameters.AddWithValue("@Rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Balance_quantity", Convert.ToInt32(TextBox3.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_master1 set Item_name=@Item_name,Category=@Category where Rate=@Rate, Item_id=@Item_id";

            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Item_name", (TextBox1.Text));
            command.Parameters.AddWithValue("@Category", (DropDownList1.Text));
            command.Parameters.AddWithValue("@Rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Item_Id", Convert.ToInt32(TextBox3.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}