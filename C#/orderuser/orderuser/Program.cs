using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderuser
{

    class car
    {
        int year;
        string model;
        string brand;
        string price;
        //creating member functions
        public void getdata(int y, string m, string b, string p)
        {
            year = y;
            model = m;
            brand = b;
            price = p;
        }
        public void displaydata()
        {

            Console.WriteLine("year " + year);
            Console.WriteLine("model " + model);
            Console.WriteLine("brand" + brand);
            Console.WriteLine("prize" + price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            car c1 = new car();
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter model");
            string model = Console.ReadLine();
            Console.WriteLine("enter brand");
            string brand = Console.ReadLine();
            Console.WriteLine("enter price");
            string price = Console.ReadLine();

            c1.getdata(year, model, brand, price);
            c1.displaydata();
        }
    }
}

