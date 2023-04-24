using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace select_country_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            // MessageBox.Show(country);
            switch (country)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Hydrabad");
                    break;
                case "USA":
                    comboBox2.Items.Add("USA");
                    comboBox2.Items.Add("Africa");
                    comboBox2.Items.Add("Tokyo");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "country : " + comboBox1.Text + "\n";
            label3.Text += "city : " + comboBox2.Text + "\n";

            label3.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";
            label3.Text+="dob": + dateTimePicker1.Text + "\n";
            label3.Text += "phone no:" + maskedTextBox1.Text + "\n";



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            // MessageBox.Show(country);
            switch (country)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Hydrabad");
                    break;
                case "USA":
                    comboBox2.Items.Add("USA");
                    comboBox2.Items.Add("Africa");
                    comboBox2.Items.Add("Tokyo");
                    break;

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string city = comboBox1.Text;
            // MessageBox.Show(city);
            switch (city)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Hydrabad");
                    break;
                case "USA":
                    comboBox2.Items.Add("USA");
                    comboBox2.Items.Add("Africa");
                    comboBox2.Items.Add("Tokyo");
                    break;


            }
        }   
    }

}