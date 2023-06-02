using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace disposite_amount.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int amt = 1000;
            int amount =Convert.ToInt32(TextBox2.Text);
            string type=Convert.ToString(TextBox3.Text);
            int totalamount = 0;
            if (type == "deposit")
            {
                totalamount = amount + 1000;
                Label1.Text = totalamount.ToString();
            }
            else
            {
                totalamount = 1000 - amount;
                Label1.Text = totalamount.ToString();
            }
          
        }

    }

}
