using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accountbalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox1.Text);
            if (amount > 0)
            {
                bal = bal + amount;
                label3.Text = "amount, deposite bal is" + bal;
            }
            else
            {
                label3.Text = "enter amount greater than 0";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox2.Text);
            if (amount <= bal)
            {
                bal = bal - amount;
                label3.Text = "amount with bal is" + bal;
            }
            else
            {
                label3.Text = "insuficient fund";

            }
        }

    }


}


