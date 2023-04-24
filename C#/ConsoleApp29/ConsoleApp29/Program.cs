using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main()
        {
            //program to accept 3no.and display greater no.
            int num1, num2, num3;
            Console.Write("enter the num 1");
            Console.Write("enter the num 2");
            Console.Write("enter the num 3");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2 is grater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
            Console.ReadKey();
        }
    }
}
           