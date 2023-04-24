using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main()
        {
            int i;
            Console.WriteLine("enter number is an even number");
            i=int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("enter number is an even number");
                    }
            else
            {
                Console.WriteLine("enter number is odd");
                Console.ReadKey();
            }

            }
        }
    }

