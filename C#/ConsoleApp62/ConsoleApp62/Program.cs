using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        static void square(int num)
        {

            int sq = num * num;
            Console.WriteLine("square = " + sq);
        }
        static void Main(string[] args)
        {
            int num = 5;
            square(num); // calling the method display
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
