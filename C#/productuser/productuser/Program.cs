using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productuser
{
    class customer
    {
        int custid;
        string name;
        string address;
        string mobno;
        //creating member functions
        public void getdata(int i, string n, string a, string m)
        {
            custid = i;
            name = n;
            address = a;
            mobno = m;
        }
        public void displaydata()
        {

            Console.WriteLine("custid " + custid);
            Console.WriteLine("name " + name);
            Console.WriteLine("address" + address);
            Console.WriteLine("mobno"+mobno);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            customer stud1 = new customer();
            Console.WriteLine("enter custid");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter address");
            string address = Console.ReadLine();
            Console.WriteLine("enter mobno");
            string mobno = Console.ReadLine();

            stud1.getdata(custid, name, address,mobno);
            stud1.displaydata();
        }
    }
}


