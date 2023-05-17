using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection string
            string constr = "server=OREO\\SQLEXPRESS;integrated security=true;database=budget;";
            //connection
            SqlConnection conn=new SqlConnection(constr);
            try
            {


                conn.Open();
                label1.Text = "connection succesful";
            }
            catch(Exception ee)
            
            {
                label1.Text =ee. ToString();

            }
            finally { conn.Close(); }   



        }
    }
}
