using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace system_web.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("nagpur");
                    DropDownList2.Items.Add("mumbai");
                    break;

                case "Nepal":
                    DropDownList2.Items.Add("Kahmandu");
                    DropDownList2.Items.Add("Lalitpur");
                    break;

                    

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Country" + DropDownList1.Text + "<br>");
            sb.Append("city" + DropDownList2.Text + "<br>");
            foreach(ListItem list  in CheckBoxList1.Items)
            {
                if(list.Selected)
                {
                    sb.Append("course " + list.Value + "<br>");
                }

            }
            sb.Append("center" + ListBox1.SelectedItem.ToString() + "<br>");
            Label1.Text = sb.ToString();

        }
    }

        
    
}