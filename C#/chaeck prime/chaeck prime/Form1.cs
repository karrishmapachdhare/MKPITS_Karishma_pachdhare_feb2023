using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaeck_prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isprime = 0;
            int num = Convert.ToInt32(textBox1.Text);
            for (int counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isprime++;
                    break;
                }
            }
            if (isprime == 0)
            {
                label2.Text = "enter number is prime";
            }
            else
            {
                label2.Text = "not prime";
            }
        }
    }
}
    

