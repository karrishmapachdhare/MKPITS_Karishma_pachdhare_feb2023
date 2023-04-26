
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeparametere
{
    class employee
    {
        int empid;
        string name;
        //creating member functions
        public void getdata(int i, string n)
        {
            empid = i;
            name = n;
        }
        public void displaydata()
        {

            Console.WriteLine("id"+empid);
            Console.WriteLine("name " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.getdata(444, "sejal");

            emp1.displaydata();
        }
    }
}