using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor_prg
{
    class employee
    {

        int empno;
        string empname;
        //creating destructor
        employee()
        {
            Console.WriteLine("in destructor we write ode to lean up operation like closing a file etc");

        }
        public employee(int empno, string empname)
        {
            this.empno = empno;
            this.empname = empname;
        }
        public void display()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                employee emp = new employee(123, "yogesh");
                emp.display();
                Console.ReadLine();

            }
        }
    }

}
