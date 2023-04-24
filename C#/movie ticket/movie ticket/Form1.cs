using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_ticket
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

        private void Book_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Bhola":
                    comboBox2.Items.Add("liberty");
                    comboBox2.Items.Add("cinemax");
                    break;
                case "Tu Jhuti Mein Makkar":
                    comboBox2.Items.Add("smruti");
                    comboBox2.Items.Add("inox");
                    break;
                case "Ved":
                    comboBox2.Items.Add("alankar");
                    comboBox2.Items.Add("sudama");

                    break;
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
                        textBox1.Text = "100";
                        break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
