using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
     class Program
    {
        static void Main(string[] args)
        {//write a program to accept 2 no. and print addtion of 2 no.
            int num1, num2;
            Console.WriteLine("enter number1 ");
            num1 = Convert.ToInt32(Console.ReadLine()); //toint32 method will convert string to integer
            Console.WriteLine("enter number2 ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("addition of 2num = " + result);
            Console.ReadLine();

        }
    }
}
