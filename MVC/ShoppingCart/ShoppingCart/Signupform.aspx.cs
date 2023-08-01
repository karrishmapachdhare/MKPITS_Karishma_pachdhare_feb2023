using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart
{
    public partial class Signupform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            string str = "insert into users(UserName,pwd) values(@username,@pwd)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@username", TextBox1.Text);
            command.Parameters.AddWithValue("@pwd", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label1.Text = "signup successfull";

        }
    }
}


        
    
