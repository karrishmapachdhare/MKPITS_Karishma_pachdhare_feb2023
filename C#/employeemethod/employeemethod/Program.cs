using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeemethod
{
    class employee

    {
        int id;
        int age;
        int mobno;
        string name;
        string address;
        //creating member function
        public void getdata()
        {
            id = 1234;
            age = 20;
            mobno = 987554;
            name = "yogesh";
            address = "mankapur";
        }
        public void displaydata()
        {
            Console.WriteLine( "id"+id );
            Console.WriteLine("age" + age);
            Console.WriteLine("mobno" + mobno);
            Console.WriteLine("name" + name);
            Console.WriteLine("address"+address);
        }
    }


       
    class Program
    {

        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.getdata();
            emp1.displaydata();
        }
    }
}
