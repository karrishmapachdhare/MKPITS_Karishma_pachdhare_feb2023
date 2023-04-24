using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result = cal.calculateresult(Convert.ToInt32(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
        calculator cal = new calculator();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.plusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.minusclick(Convert.ToInt32(textBox1.Text)));
        }
    }
    
}
