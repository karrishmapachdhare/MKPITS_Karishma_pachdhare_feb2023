using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendhal_company
{
    public static class product_store
    {
        
        

            //create static variable
            private static string connection = "server=OREO\\SQLEXPRESS;integrated security=true;database=Fendhal;";
            //create static method
            public static SqlConnection GetSqlConnection()
            {
                SqlConnection con = new SqlConnection(connection);
                try
                {
                    con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    //con.Close();
                }
            }
            public static DataSet GettableProductCategory()
            {
                SqlConnection conn = GetSqlConnection();
                string query = "select * from ProductCategory";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "Product_type_Name");
                return ds;
            }
            public static DataSet GettableProductName(string Product_type_Name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select p.Product_Id, p.product_Name from Products p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_Id   where t.Product_type_Name = @product_type_name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_Name);
                da.Fill(ds, "Products");
                return ds;

            }
            //method to return gstdetails for given product name
            public static DataSet GetGstDetails(string Product_type_Name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select a.cgst,a.sgst,a.igst from ProductGstDetails a inner join ProductCategory b on a.Product_Gst_Id=b.Product_Gst_id where b.Product_type_Name=@Product_type_Name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_type_Name);
                da.Fill(ds, "ProductCategory");
                return ds;
            }
            public static DataSet GetProductPrice(string Product_Name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select price from Products where Product_Name=@Product_Name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
                da.Fill(ds, "Products");
                return ds;

            }
            public static string SaveTableInvoiceDetails(string Customer_Name, int Customer_Contact, int Product_Category_id, int Product_id, int Residential_Type_Id, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_Value, decimal IGST_Value, decimal Total_Amount)
            {
                SqlConnection con = GetSqlConnection();
                string query = "insert into InvoiceDetails values(@customername,@customercontact,@productcategoryid,@productid,@residentialtypeid,@invoicedate,@quantity,@price,@cgst,@sgst,@igst,@cgstvalue,@sgstvalue,@igstvalue,@totalamount)";
                string result = null;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customername", Customer_Name);
                cmd.Parameters.AddWithValue("@customercontact", Customer_Contact);
                cmd.Parameters.AddWithValue("@productcategoryid", Product_Category_id);
                cmd.Parameters.AddWithValue("@productid", Product_id);
                cmd.Parameters.AddWithValue("@residentialtypeid", Residential_Type_Id);
                cmd.Parameters.AddWithValue("@invoicedate", Invoice_Date);
                cmd.Parameters.AddWithValue("@quantity", Quantity);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@cgst", CGST);
                cmd.Parameters.AddWithValue("@sgst", SGST);
                cmd.Parameters.AddWithValue("@igst", IGST);
                cmd.Parameters.AddWithValue("@cgstvalue", CGST_Value);
                cmd.Parameters.AddWithValue("@sgstvalue", SGST_Value);
                cmd.Parameters.AddWithValue("@igstvalue", IGST_Value);
                cmd.Parameters.AddWithValue("@totalamount", Total_Amount);
                try
                {
                    cmd.ExecuteNonQuery();
                    return "record saved successfully";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally 
                {
                con.Close();
               
                }
                return result;

            }
    }

    
}
