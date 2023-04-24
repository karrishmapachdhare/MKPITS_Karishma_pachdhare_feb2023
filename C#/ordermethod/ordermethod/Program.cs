using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordermethod
{
    class order

    {
        int no;
        string customer_name;
        int total_amount;
        string items;
        int order_time;
        //creating member function
        public void getdata()
        {
            no = 2345;
            customer_name = "dhanshree";
            total_amount = 520;
            items = "noodles";
            order_time = 9;
        }
        public void displaydata()
        {
            Console.WriteLine("no" + no);
            Console.WriteLine("customer_name" + customer_name);
            Console.WriteLine("total_amount" +total_amount);
            Console.WriteLine("items" + items);
            Console.WriteLine("order_time" +order_time);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            order ord1 = new order();
            ord1.getdata();
            ord1.displaydata();
        }
    }
}
