using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Number1, Number2, res = 0;
            Number1=Convert.ToInt32(TextBox1.Text);
            Number2=Convert.ToInt32(TextBox2.Text);
            res=Number1+ Number2;   
            Label1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Number1, Number2, res = 0;
            Number1 = Convert.ToInt32(TextBox1.Text);
            Number2 = Convert.ToInt32(TextBox2.Text);
            res = Number1 - Number2;
            Label1.Text = res.ToString();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int Number1, Number2, res = 0;
            Number1 = Convert.ToInt32(TextBox1.Text);
            Number2 = Convert.ToInt32(TextBox2.Text);
            res = Number1 * Number2;
            Label1.Text = res.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int Number1, Number2, res = 0;
            Number1 = Convert.ToInt32(TextBox1.Text);
            Number2 = Convert.ToInt32(TextBox2.Text);
            res = Number1 / Number2;
            Label1.Text = res.ToString();
        }
    }
}