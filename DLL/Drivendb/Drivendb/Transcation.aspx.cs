using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Drivendb
{
    public partial class Transcation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=OREO\\SQLEXPRESS;integrated security=true;database=Drivenitdb");
        SqlCommand command = null;
        string query = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@Itemid,@TransType,@TransQty,@TranseDate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("Itemid", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";

                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox2.Text));
                command.Parameters.AddWithValue("@TranseDate", TextBox3.Text);
                con.Open();
                command.ExecuteNonQuery();
                //getting the balqty from Itemmaster table for particular item id
                query = "select max(BalQty) from ItemMaster where Itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox2.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox2.Text);
                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@balqty where Itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@Itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();

            }

        }
        static int transid = 0;
        static int oldtransqty = 0;

        protected void Button2_Click(object sender, EventArgs e)
        {
            int updatedqty = 0;

            Response.Write("transaction id" + transid.ToString());
            updatedqty = Convert.ToInt32(TextBox2.Text) - oldtransqty;

            Response.Write("updated qty" + updatedqty.ToString());
            try
            {
                query = "update Transactions set TransType=@transtype,TransQty=@transqty,TranseDate=@transdate where Itemid = @itemid";
                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {

                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox2.Text));
                command.Parameters.AddWithValue("@transdate", TextBox3.Text);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@transid", transid);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(BalQty) from ItemMaster where Itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq " + bq.ToString());
                Response.Write("updateqty " + updatedqty.ToString());
                if (RadioButton1.Checked)
                    bq = bq - updatedqty;
                if (RadioButton2.Checked)
                    bq = bq + updatedqty;

                Response.Write("<br>newupdateqty " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {
                    //if (transt == "I")
                    //{
                    //    bq = bq - Convert.ToInt32(TextBox2.Text);
                    //}
                    //else if (transt == "R")
                    //{
                    //    bq = bq + Convert.ToInt32(TextBox2.Text);
                    //}

                    //updating bal qty on item master table
                    query = "update ItemMaster set BalQty=@balqty where Itemid=@itemid";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balqty", bq);
                    command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                    command.ExecuteNonQuery();

                    Label1.Text = "record updated successfully";
                }
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }

            finally
            {
                con.Close();
            }

        
        }
        


        protected void Button3_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        query = "delete Transactions set TransType=@transtype,TransQty=@transqty,TranseDate=@transdate where Itemid = @itemid";
        //        command = new SqlCommand(query, con);

        //        string transt = null;
        //        if (RadioButton1.Checked)
        //        {
        //            transt = "I";
        //        }
        //        else if (RadioButton2.Checked)
        //        {

        //            transt = "R";
        //        }
        //        command.Parameters.AddWithValue("@transtype", transt);
        //        command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox2.Text));
        //        command.Parameters.AddWithValue("@transdate", TextBox3.Text);
        //        command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
        //        con.Open();
        //        command.ExecuteNonQuery();

        //        //getting the balqty from itemmaster table for particular item id
        //        query = "select max(BalQty) from ItemMaster where Itemid=@itemid";
        //        command = new SqlCommand(query, con);
        //        command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
        //        int bq = Convert.ToInt32(command.ExecuteScalar());
        //        if (transt == "I")
        //        {
        //            bq = bq - Convert.ToInt32(TextBox2.Text);
        //        }
        //        else if (transt == "R")
        //        {
        //            bq = bq + Convert.ToInt32(TextBox2.Text);
        //        }

        //        //updating bal qty on item master table
        //        query = "delete ItemMaster set BalQty=@balqty where Itemid=@itemid";
        //        command = new SqlCommand(query, con);
        //        command.Parameters.AddWithValue("@balqty", bq);
        //        command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
        //        command.ExecuteNonQuery();

        //        Label1.Text = "record delete successfully";
        //    }
        //    catch (Exception ex)
        //    {

        //        Label1.Text = ex.ToString();
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }


        
        
        
        
        
        
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
           // TextBox3.Text = GridView1.SelectedRow.Cells[5].Text;
            oldtransqty =Convert.ToInt32(TextBox2.Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox3.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
            
            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res =="I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if(res =="R")
            {
                RadioButton1.Checked= false;
                RadioButton2.Checked= true;
            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

            

            
        }
    }
}