using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;



namespace product_store
{
    public static class productstore
    {
        private static string connectionString = "server=OREO\\SQLEXPRESS;integrated security=true;database=fendhl;";
        //method to create connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)

            {
                return null;
            }
            finally
            {
               // con.Close();
            }
        }

        //method to return product category
        public static DataSet GettableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from ProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "tableProductCategory");
            return ds;
        }
        //method to return product name for given product type name
        public static DataSet GettableProductName(string Product_type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_id, p.Product_Name from Products p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_Id   where t.Product_type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_Name);
            da.Fill(ds, "tableProducts");
            return ds;

        }
        //method to return gstdetails for given product name
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from ProductGstDetails a inner join ProductCategory b on a.Product_Gst_Id=b.Product_Gst_id where b.Product_type_Name=@product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "ProductCategory");
            return ds;
        }
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select Price from Products where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
            da.Fill(ds, "products");
            return ds;

        }



        //method to save record inside invoice table
        public static string saveTableInvoiceDetails1(string customer_name, string customer_contact, int product_category_id, int product_id, int residential_type_id, DateTime invoice_date , decimal quantity, decimal price, decimal cgst, decimal sgst, decimal igst, decimal cgst_value, decimal sgst_value, decimal igst_value, decimal total_amount)
        {
            string result = null;
            // System.Windows.Forms.MessageBox.Show(invoice_date.ToString());
            string query = "insert into InvoiceDetails1 values(@customer_name, @customer_contact, @product_category_id, @product_id, @residential_type_id, @invoice_date, @quantity, @price, @cgst, @sgst, @igst, @cgst_value, @sgst_value,@igst_value,@total_amount)";
            SqlConnection con = GetConnection();
          
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@customer_name", customer_name);
            command.Parameters.AddWithValue("@customer_contact", customer_contact);
            command.Parameters.AddWithValue("@product_category_id", product_category_id);
            command.Parameters.AddWithValue("@product_id", product_id);
            command.Parameters.AddWithValue("@residential_type_id", residential_type_id);
            command.Parameters.AddWithValue("@invoice_date", invoice_date);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@cgst", cgst);
            command.Parameters.AddWithValue("@sgst", sgst);
            command.Parameters.AddWithValue("@igst", igst);
            command.Parameters.AddWithValue("@cgst_value", cgst_value);
            command.Parameters.AddWithValue("@sgst_value", sgst_value);
            command.Parameters.AddWithValue("@igst_value", igst_value);
            command.Parameters.AddWithValue("@total_amount", total_amount);
            try

            {
                command.ExecuteNonQuery();
                result = "record saved successfullly";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;

        }

    }

}


    
    

