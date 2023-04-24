using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details_from_user
{
    class employee
    {
        int id;
        string Name;
        string password;
        string department;
        //creating member functions
        public void getdata(int i, string n,string p,string d)
        {
            id= i;
            Name= n;
            password= p;
            department= d;
        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("name" + Name);
            Console.WriteLine("password" + password);
            Console.WriteLine("department");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            Console.WriteLine("enter id");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name= Console.ReadLine();
            Console.WriteLine("enter password");
            string password= Console.ReadLine();
            Console.WriteLine("enter department");
            string department= Console.ReadLine();

            emp1.getdata(id,name,password,department);
            emp1.displaydata();
            Console.ReadLine();

        }
    }
}
