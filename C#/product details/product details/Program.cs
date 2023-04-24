using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace product_details
{
    class product
    {
        int id;
        int unit;
        string productcategory;
        string productname;
        string productdescription;
        string productprice;
        string quntity;
        //creating member functions
        public void getdata()
        {
            id = 1234;
            unit =500;
            productcategory = "shopping goods";
            productname = "Toyota company";
            productdescription = "social proof";
            productprice = "245000";
            quntity = "14";

        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("unit" + unit);
            Console.WriteLine("productdesription"+productdescription);
            Console.WriteLine("productprice" + productprice);
            Console.WriteLine("quntity" + quntity);

        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            product pro1=new product();
            pro1.getdata();
            pro1.displaydata();
            Console.ReadLine();


        }
    }
}
