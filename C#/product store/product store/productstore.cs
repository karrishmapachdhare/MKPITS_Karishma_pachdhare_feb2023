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
        //method to creeate connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // con.Open();
                return con;
            }
            catch (Exception ee)

            {
                return null;
            }
            finally
            {
                //con.Close();
            }
        }

        //method to return product category
        public static DataSet Gettableproductcategory()
        {
            SqlConnection con = GetConnection();
            string query = "select Product_type_Name from ProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds,"ProductCategory");
            return ds;

        }

        //method to return product name for given product type name
        public static DataSet GettableProductName(string Product_type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_Name from Product p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_ID where t.Product_Type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_Name);
            da.Fill(ds, "Products");
            return ds;

        }

        //method to return gstdetails for given product name
        public static DataSet GetGstDetails(string Product_type_Name)
        {
            SqlConnection con = GetConnection();

            string query = " select a.cgst,a.sgst,a.igst from ProductGstDetails a inner join ProductCategory b on a.Product_Gst_Id = b.product_gst_id where b.Product_Type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_Name);
            da.Fill(ds, "ProductGstDetails");
            return ds;

        }
        //method to return product price for given product_name 
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select Price from Products where Product_Name=@product_name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
            da.Fill(ds2, "Products");
            return ds2;

        }
    }
}
