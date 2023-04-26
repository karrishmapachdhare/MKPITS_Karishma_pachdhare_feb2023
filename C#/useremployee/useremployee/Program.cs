using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useremployee
{
    class student
    {
        int id;
        string name;
        string address;
        //creating member functions
        public void getdata(int i, string n,string a)
        {
            id = i;
            name = n;
            address = a;
        }
        public void displaydata()
        {

            Console.WriteLine("id " + id);
            Console.WriteLine("name " + name);
            Console.WriteLine("address" + address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            student stud1 = new student();
            Console.WriteLine("enter id");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter address");
            string address = Console.ReadLine();

            stud1.getdata(rno, name, address);
            stud1.displaydata();
        }
    }
}

