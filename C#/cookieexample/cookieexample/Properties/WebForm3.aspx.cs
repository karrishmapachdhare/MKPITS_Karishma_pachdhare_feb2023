using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookieexample.Properties
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie1 = Request.Cookies["cookie"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                string uemail = cookie1.Values["email"].ToString();
                Label2.Text = "username:" + uname;
                Label3.Text = "email:" + uemail;
            }
            else
            {
                Label2.Text = "no cookie exist";
            }
        }

    }

}
