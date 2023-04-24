using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_salary_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string employeename;
        int basicsalary, hra, da, totalsalary;
        long employeeno;

        private void button1_Click(object sender, EventArgs e)
        {
         

                string employeename = Convert.ToString(textBox1.Text);
                int basicsalary = Convert.ToInt32(textBox2.Text);
                hra = (basicsalary * 35) / 100;
                da = (basicsalary * 45) / 100;
                totalsalary = basicsalary + hra + da;
                label3.Text = "hra :" + hra;
                label4.Text = "da :" + da;
                label5.Text = "totalsalary:" + totalsalary;
            }
        }
    }



    

