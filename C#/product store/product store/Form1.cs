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
        enum Nationality { Indian, NRI }

        Nationality nationality; // datatype is enum so it can store only indian or nri value only
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        public Form1()
        {
            InitializeComponent();
            //code to set date
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        // code to accept only numbers
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
            DataSet ds = productstore.GettableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
            comboBox1.ValueMember = "Product_Category_Id";
        }


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.GettableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_id";

            //filling the gst textboxes
            DataSet ds1 = productstore.GetGstDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {

                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
            }
            //code for cgst sgst
            //if (radioButton1.Checked)

            if (nationality == 0) //ie nationality is indian means value is 0

            {
                //if nationality is indian the totalgst is sum of cgst and sgst
                tgst = cgst + sgst;
            }
            else// nationality is nri  
            {
                tgst = igst; // totalgst is only igst not sum 
            }
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = tgst.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = totalamount.ToString();
            double cgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = cgstamount.ToString();
            double sgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = sgstamount.ToString();
            double igstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = igstamount.ToString();
            //double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            //textBox12.Text = netamount.ToString();
            double netamount = 0;

            if (nationality == 0)
            {
                netamount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            }
            else
            {
                netamount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            }
            textBox12.Text = netamount.ToString();

        }

        public void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }
    





    private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //filling the product price
        DataSet ds1 = productstore.GetProductPrice(comboBox2.Text);
        foreach (DataRow dr in ds1.Tables[0].Rows)
        {
            textBox9.Text = dr["Price"].ToString();

        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }


    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        nationality = Nationality.NRI;
        // MessageBox.Show(nationality.ToString());
        textBox3.Text = cgst.ToString();
        textBox4.Text = sgst.ToString();
        textBox5.Text = igst.ToString();
        calculate_total();
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {


    }

    private void button1_Click(object sender, EventArgs e)
    {
        checkuserdetails();

    }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill all the details");
            }
            else if (textBox3.Text == "0")
            {
                MessageBox.Show("quantity cannot be zero");
            }
            else
            {
                string result = productstore.saveTableInvoiceDetails1(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));

                MessageBox.Show(result);


            }

        }
    private void textBox8_TextChanged(object sender, EventArgs e)




    {
    }


    private void button2_Click(object sender, EventArgs e)
    {
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {

    }

    private void label13_Click(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        ClearAll();
    }

    private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
    {
        nationality = Nationality.Indian;
        // MessageBox.Show(nationality.ToString());
        textBox3.Text = cgst.ToString();
        textBox4.Text = sgst.ToString();
        textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
        calculate_total();
    }
    }
}
