using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverasp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello from webform1 page");
            Server.Execute("webform2.aspx");
            Response.Write("welcom back to webform1 page");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Hello from webform1 transfer page");
            Server.Transfer("webform2.aspx");
            Response.Write("welcom back to webform1 transfer page");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<H1> is an example of a Heading tag </H1>"));
            Response.Write("<H1> is an example of a Heading tag </H1>");


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost / code / map.aspx"));
            Response.Write("http://localhost / code / map.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("Karishma Pachdhare");

            Response.Redirect("webform3.aspx?name=" + name);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            String name = "Karishma Pachdhare";

            Response.Redirect("webform3.aspx?name=" + name);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            String name = Server.UrlEncode("John Saunders");

            String password = Server.UrlEncode("king");

            Response.Redirect("webform3.aspx?name= " + name + " & password = " + password);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Write("<hr>");
            Response.Write(Server.MapPath("webform3.aspx"));
        }
    }
}