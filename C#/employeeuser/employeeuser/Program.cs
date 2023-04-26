using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeuser
{
    class employee
    {
        int empid;
        string name;
        string address;
        //creating member functions
        public void getdata(int i, string n, string a)
        {
            empid = i;
            name = n;
            address = a;
        }
        public void displaydata()
        {

            Console.WriteLine("id" + empid);
            Console.WriteLine("name " + name);
            Console.WriteLine("address" + address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            string name;
            Console.WriteLine("enter name");
            Console.WriteLine("enter address");
           string address =Console.ReadLine();

            emp1.getdata(id, name, address);
                emp1.displaydata();
        }
    }

}
