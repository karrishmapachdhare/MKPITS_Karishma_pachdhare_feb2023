using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stroelibrary
{
    internal class Item_master
    {
        static SqlConnection con = Dbconnection.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in Item  table

        public static string Item_Master(string Item_name, string Category, int Rate, int Balance_quantity)
        {
            string res = null;
            try
            {
                query = "insert into Item_master values(@Item_name,@Category,@Rate,@Balance_quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_name", Item_name);
                cmd.Parameters.AddWithValue("@Categroy", Category);
                cmd.Parameters.AddWithValue("@Rate", Rate);
                cmd.Parameters.AddWithValue("@Balance_quantity", Balance_quantity);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in Item master successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        //method to return Item_id 
        public static string getItem_id()
        {
            string res = null;
            try
            {
                query = "update Item_master set Item_name=@Item_name";
                query = "select max(Item_id) from Item_master";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

               

                res = vid.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();

            }
            return res;
        }


        //method to update record in Item table
        public static string updateItem_Master(string vendor_name, int vendor_id)
        {
            string res = null;

            //checking whether Itemid exists or not
            query = "select count(*) from vendor_mast where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "update  vendor_mast set vendor_name=@vendor_name where vendor_id=@vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                    cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to delete record in vendor master

        public static string deleteVendor_Mast(int vendor_id)
        {
            string res = null;

            //checking whether.
            //vendorid exists or not
            query = "select count(*) from vendor_mast where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "delete from  vendor_mast where vendor_id=@vendor_id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to search record in vendor master

        public static DataSet searcVendor_Mast(int vendor_id)
        {

            query = "select * from  vendor_mast where vendor_id=@vendor_id";


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@vendor_id", vendor_id);
            da.Fill(ds, "vendor_mast");
            return ds;




        }

    }
}
