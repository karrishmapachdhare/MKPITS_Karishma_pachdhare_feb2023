using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reursion_fatorrial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact, num;
            Console.WriteLine("enter a number:");
            //take input fro user
            num = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();

            // calling recursive function

            fact = obj.factorial(num);

            Console.WriteLine("Factorial of {0} is {1}", num, fact);
        }

        // recursive function
        public int factorial(int num)
        {
            // termination condition
            if (num == 0)
                return 1;
            else
                // recursive call
                return num * factorial(num - 1);

        }
    }
}
