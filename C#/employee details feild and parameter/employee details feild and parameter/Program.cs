using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace employee_details_feild_and_parameter
{
    class employee
    {
        int id;
        string name;
        string password;
        string department;
        //creating member functions
        public void getdata(int i, string n, string pass,string depart)

        {
            id = i;
            name = n;
            password = pass;
            department = depart;

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
            emp1.getdata(1234,"karishma","839078","it servies");
            emp1.displaydata();
            Console.ReadLine();
        }
    }
}
