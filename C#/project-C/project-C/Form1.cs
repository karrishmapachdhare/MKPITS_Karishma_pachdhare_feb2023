using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project_C
{
    public partial class Form1 : Form
    {
        enum Gender { Male,Female}
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate= DateTime.Today;

        }
        Gender gender;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
