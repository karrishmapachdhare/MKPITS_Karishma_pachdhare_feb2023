using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace adoex2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=Fendhl");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into Products values(@Product_Id,@ProductTypeId,@Product_Name,@Price)";
             SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Product_Id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@ProductTypeId", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Product_Name",TextBox3.Text);
            command.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox4.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();

        }
        public void loaddata()
        {
            str = "select *from Products";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Products");
            GridView1.DataSource = ds.Tables["Products"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update Products set ProductTypeId=@ProductTypeId,Product_Name=@Product_Name,Price=@Price where Product_Id=@Product_Id";

            SqlCommand command= new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Producttypeid",Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Product_Name", TextBox3.Text);
            command.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@Product_Id", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from Products where Product_Id=@Product_Id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Product_Id",Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Focus ();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from Products where Product_Id=@Product_Id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Id", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "Products");

            TextBox2.Text = ds.Tables["Products"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["Products"].Rows[0].ItemArray[2].ToString();

            TextBox4.Text = ds.Tables["Products"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["products"].DefaultView;

            GridView1.DataBind();
        }
    }
}