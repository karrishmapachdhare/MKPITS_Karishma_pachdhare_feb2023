using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trustdbstoremangement
{
    public partial class Department : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=TrustDB");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;
        public void loaddata()
        {
            str = "select *from Department_master";
            dr = new SqlDataAdapter(str, con);
            dr.Fill(ds, "Item_master1");
            GridView1.DataSource = ds.Tables["Item_master1"].DefaultView;
            GridView1.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Department_master values(@Department_name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_name", TextBox2.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
            // loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_master set Department_name=@Department_name";

            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Department_name", TextBox2.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record Update";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Department_master where Department_name=@Department_name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_name", TextBox2.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Focus();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Department_master where Department_id=@Department_id";
            SqlCommand command = new SqlCommand(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Department_id", Convert.ToInt32(TextBox1.Text));
            dr.Fill(ds, "Department_master");
            TextBox1.Text = ds.Tables["Department_master"].Rows[0].ItemArray[0].ToString();
            TextBox2.Text = ds.Tables["Department_master"].Rows[0].ItemArray[1].ToString();

            GridView1.DataSource = ds.Tables["Department_master"].DefaultView;
            GridView1.DataBind();

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record search";
            TextBox1.Text = "";
            TextBox1.Focus();

        }

        protected void Page_Load(object sender, EventArgs e)

        {
            loaddata();
        }

    }
}