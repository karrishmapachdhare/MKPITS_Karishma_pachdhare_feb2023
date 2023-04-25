using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methodcompany
{
    class employee
    {
        public int empno;
        public string name;
        public static string companyname = "Fendahl";
        public employee(int empno, string name)
        {
            this.empno = empno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("companyname" + companyname);
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + name);
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int empno;
            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());
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

  

