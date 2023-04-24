using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to accept 2 no. and print greater no
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2)
            {

                Console.WriteLine("num1 is not greter");
            }

            else
            {
                Console.WriteLine("num2 is  greter");
                Console.ReadLine();

            }
            }
        }
    }


