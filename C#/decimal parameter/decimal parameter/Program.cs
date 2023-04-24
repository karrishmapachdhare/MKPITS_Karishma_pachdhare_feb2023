//WRITE A C# METHOD THAT TAKES A DECIMAL AS A PARAMETER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("enter a number:");
            number=float.Parse(Console.ReadLine());
            double num = Math.Floor(number);
            //Console.WriteLine(number);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
