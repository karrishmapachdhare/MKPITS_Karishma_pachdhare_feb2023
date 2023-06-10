using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionapplication
{
    public partial class Viewinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (String)Session["username"];
            Label2.Text = (String)Session["email"];
        }
    }
}