using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal class Program
    {
        static void Main()
        {
            int num = 4;

            int counter;
            int isprime = 0;
            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isprime = 1;
                    break;
                }
            }
            if (isprime == 0)
            {
                Console.WriteLine("it is a prime no");
            }
        else
            {
                Console.WriteLine("it is a not prime no");
                Console.ReadKey();
            }
        }
            
        
    }
}
