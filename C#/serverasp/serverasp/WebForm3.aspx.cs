﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverasp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string n =Request.QueryString["name"].ToString();
            Response.Write("name is: " + n);
            string p = Request.QueryString["password"].ToString();
            Response.Write("password" + p);
        }
    }
}