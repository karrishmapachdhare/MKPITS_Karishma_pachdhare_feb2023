﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado.net1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = databaseconnection.GetConnection();
            if (con != null)
            {
                label1.Text = "connected successfully";

                con.Close();
            }
            else
            {
                label1.Text = "unable to connect";

            }
        }
    }
}
