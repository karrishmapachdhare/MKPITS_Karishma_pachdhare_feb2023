using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employedetails
{
    class employee
    {
        int id;

        string name;
        string password;
        string department;
        //creating member functions
        public void getdata()
        {
            id = 9876;
            name = "karishma";
            password = "839078";
            department = "IT services";

        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("name" + name);
            Console.WriteLine("password" + password);
            Console.WriteLine("department" + department);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.getdata();
            emp1.displaydata();
            Console.ReadLine();
        }
    }
}
