using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollno, age, mobile;
            string name, courese;
            Console.WriteLine("please enter rollno");
            Console.WriteLine("please enter age");
            Console.WriteLine("please enter mobile");
            Console.WriteLine("please enter name");
            Console.WriteLine("please enter course");

            rollno = Convert.ToInt32(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());
            mobile = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            courese = Console.ReadLine();
            Console.WriteLine(rollno);
            Console.WriteLine(age);
            Console.WriteLine(mobile);
            Console.WriteLine(name);
            Console.WriteLine(courese);
            Console.ReadKey();
        }
    }
}
