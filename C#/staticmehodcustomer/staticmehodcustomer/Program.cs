using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmehodcustomer
{
    class customer
    {
        public int custid;
        public string name;
        public string address;
        public static string companyname = "civica";
        public customer(int custid, string name,string address)
        {
            this.custid = custid;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("companyname" + companyname);
            Console.WriteLine("custid" + custid);
            Console.WriteLine("empname" + name);
            Console.WriteLine("address" + address);
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int custid;
            Console.WriteLine("enter custid");
            custid = Convert.ToInt32(Console.ReadLine());
            string name;
            Console.WriteLine("enter name ");
            name = Console.ReadLine();



            employee emp1 = new employee(empno, name);
            employee emp2 = new employee(empno, "name");
            emp1.display();
            emp2.display();
            Console.ReadLine();
        }
    }
}

  


}
