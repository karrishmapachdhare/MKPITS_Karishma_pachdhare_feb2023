using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productuserex
{
    class product
    {
        int id;
        string name;
        string discription;
        string quality;
        //creating member functions
        public void getdata(int i, string n, string d, string q)
        {
            id = i;
            name = n;
            discription = d;
            quality = q;
        }
        public void displaydata()
        {

            Console.WriteLine("id " + id);
            Console.WriteLine("name " + name);
            Console.WriteLine("discription" + discription);
            Console.WriteLine("quality" + quality);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            product stud1 = new product();
            Console.WriteLine("enter id");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter discription");
            string discription = Console.ReadLine();
            Console.WriteLine("enter quality");
            string quality = Console.ReadLine();

            stud1.getdata(custid, name, discription, quality);
            stud1.displaydata();
        }
    }
}


