using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_A
{
    public partial class Form1 : Form
    {
        enum StudentCategory {Student ,ITprofessional }
        enum Gender { Male,Female}
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds= new DataSet();
            ds = CourseRegistration.GetNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.GetState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateId";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables["TableCity"];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityId";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
