using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_feild_metohd_parameter
{
    
        class product
        {
            int id;
            int unit;
            string category;
            string name;
            string description;
            string price;
            string quntity;
            //creating member functions
            public void getdata(int i,int u,string cat,string n,string des,string p,string qun)
            {
                id = i;
                unit = u;
               category = cat;
                name = n;
                description = des;
                price = p;
                quntity = qun;

            }
            public void displaydata()
            {
                Console.WriteLine("id" + id);
                Console.WriteLine("unit" + unit);
                Console.WriteLine("desription" + description);
                Console.WriteLine("price" + price);
                Console.WriteLine("quntity" + quntity);

            }

        }

        internal class Program
        {
        static void Main(string[] args)
        {
            product pro1 = new product();
            pro1.getdata(1234, 500,"toyota company", "234000", "10");
            pro1.displaydata();
            Console.ReadLine();

        }
                
    }
}
