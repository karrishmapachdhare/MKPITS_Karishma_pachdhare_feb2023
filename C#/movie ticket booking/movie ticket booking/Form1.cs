using movie_ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace movie_ticket_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MovieName = comboBox1.Text;
            string TheatreName = comboBox2.Text;
            string ShowTime = comboBox3.Text;
            int NoOfSeats = Convert.ToInt32(numericUpDown1.Value);
            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new Online_Booking(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                mt = new Box_Office(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));

            }

            label7.Text += MovieName + Environment.NewLine; 
            label7.Text += TheatreName + Environment.NewLine; 
            label7.Text += ShowTime + Environment.NewLine; 
            label7.Text += NoOfSeats + Environment.NewLine;  
            label7.Text += mt.Calculate_Ticket_Price();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Ved":
                    comboBox2.Items.Add("liberty");
                    comboBox2.Items.Add("cinemax");
                    break;
                case "Dasara":
                    comboBox2.Items.Add("smruti");
                    comboBox2.Items.Add("inox");
                    break;
                case "Pathan":
                    comboBox2.Items.Add("alankar");
                    comboBox2.Items.Add("sudama");

                    break; 
                case "Tu Jhuti Mein Makkar":
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Liberty");

                    break; 
                case "Bhola":
                    comboBox2.Items.Add("Sudama");
                    comboBox2.Items.Add("Inox");

                    break;



            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "liberty":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("03.00 PM");
                    textBox1.Text = "120";
                    break;
                case "cinemax":
                    comboBox3.Items.Add("10.30 AM");
                    comboBox3.Items.Add("01.30 PM");
                    textBox1.Text = "420";
                    break;
                case "smruti":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "300";
                    break;
                case "Alankar":
                    comboBox3.Items.Add("03.00 PM");
                    comboBox3.Items.Add("09.00 PM");
                    textBox1.Text = "250";
                    break;
               case "Inox":
                    comboBox3.Items.Add("09.00 PM");
                    comboBox3.Items.Add("09.12 PM");
                    textBox1.Text = "100";
                     break;

            }
        }
    }
    
}
