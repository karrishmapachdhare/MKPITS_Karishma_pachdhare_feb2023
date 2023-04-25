using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeedisplaymethod
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
            employee a1 = new employee(2344, "tina");
            employee a2 = new employee(6538, "diksha");
            
            a1.display();
            a2.display();
            Console.ReadLine();
        }
    }
}
