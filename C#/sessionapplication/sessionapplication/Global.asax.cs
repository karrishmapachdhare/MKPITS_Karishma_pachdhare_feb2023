using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace sessionapplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["companyname"] = "MKPITS SERVICES";
            Application["counter"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            //code that runs when session is started
            Session["usercount"] = 0;
            Session["username"] = "";
            Session["email"] = "";
        }
    }
}