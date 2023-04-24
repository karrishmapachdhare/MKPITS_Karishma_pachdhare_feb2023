using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_inheritane_child
{
    class person
    {
        public string name;
        public string address;
    }
    //inheriting a new child class from person class
    class employee : person 
    {
        public int empno;
        public int salary;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.name = "siddhi";
            emp.address = "nagpur";
            emp.salary = 12345;
            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.name);
            Console.WriteLine("emp addres " + emp.address);
            Console.WriteLine("emp salary " + emp.salary);


        }
    }
}
