using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmethod
{
    class product

    {
        int id;
        int price;
        string name;
        string discription;
        int date;
        //creating member function
        public void getdata()
        {
            id = 1234;
            price = 560;
            name = "karishma";
            discription="usefulg gadgate";
            date=28;
        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("price" + price);
            Console.WriteLine("name" + name);
            Console.WriteLine("discription" + discription);
            Console.WriteLine("date" + date);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            product pro1 = new product();
            pro1.getdata();
            pro1.displaydata();
        }
    }
}
