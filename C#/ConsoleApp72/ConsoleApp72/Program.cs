using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main()
        {
            int number, result;
            Console.WriteLine("enter number");
            number = Console.ToInt(Console.ReadLine());
            result = fact(number);
            Console.Write("factorial=" + result);
            Console.ReadLine();
        }
        static void factorial(int number)
        {
            int fact = 1, i;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
            

            













                
        }
    }
}
