using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace age_result.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(TextBox1.Text);
        if (age>=18)
            {
                Label1.Text = "You are eligible for vote";
            }
            else
            {
                Label1.Text = "Not eligible for vote";
            }
        }
    }
}