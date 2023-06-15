using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using stroelibrary;
using System.Data;

namespace trustproject
{
    public partial class vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getVendorid();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_Mast(TextBox2.Text);
            Label1.Text = res;
            getVendorid();
            TextBox2.Text = "";

        }
        public void getVendorid()
        {
            int res=Convert.ToInt32(VendorClass.getVendor_id());
            res = res + 1;
            TextBox1.Text = res.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.updateVendor_Mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendor_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searcVendor_Mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";

            }
        }      
    
    }
}