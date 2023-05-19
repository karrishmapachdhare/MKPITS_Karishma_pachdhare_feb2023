using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace product_store
{
    public partial class Form1 : Form
    {
        //creating an enum Nationality
        enum Nationality { Indian,NRI}
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = productstore.Gettableproductcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.Gettableproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";

            //filling the gst textboxes
            DataSet ds1 = productstore.GetGstDetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString()) ;
            }

            if (nationality == 0)

            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox5.Text = cgst.ToString();
            textBox6.Text = sgst.ToString();
            textBox7.Text = tgst.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filling the product price
            DataSet ds1 = productstore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox4.Text = dr["productprice"].ToString();

            }
        }
        Nationality nationality;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            // MessageBox.Show(nationality.ToString());
            textBox5.Text = cgst.ToString();
            textBox6.Text = sgst.ToString();

            textBox7.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            // MessageBox.Show(nationality.ToString());
            textBox5.Text = cgst.ToString();
            textBox6.Text = sgst.ToString();
            textBox7.Text = igst.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

            }
            else
            {
                double totalamount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox3.Text);
                textBox8.Text = totalamount.ToString();
                double cgstamount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
                textBox10.Text = cgstamount.ToString();
                double sgstamount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox6.Text) / 100.0);
                textBox11.Text = sgstamount.ToString();
                double igstamount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox7.Text) / 100.0);
                textBox12.Text = igstamount.ToString();
                double netamount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox12.Text);
                textBox9.Text = netamount.ToString();
            }
        }
    }
}
