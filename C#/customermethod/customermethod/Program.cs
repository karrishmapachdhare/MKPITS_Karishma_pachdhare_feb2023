using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace customermethod
{
    class car

    {
        string model;
        int price;
        int year;
        string make;
        string colour;
        int date;
        //creating member function
        public void getdata()
        {
            model = "civic";
            price = 1000000;
            year=2022;
            make = "honda";
            colour="red";
            date = 20;
        }
        public void displaydata()
        {
            Console.WriteLine("model" + model);
            Console.WriteLine("price" + price);
            Console.WriteLine("year" + year);
            Console.WriteLine("make" + make);
            Console.WriteLine("date" + date);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            car ca1 = new car();
            ca1.getdata();
            ca1.displaydata();
        }
    }
}


