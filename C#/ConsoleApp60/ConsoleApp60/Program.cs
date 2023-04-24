using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Program
    {
        static void square()
        {
            int num = 5;
            int sq = num * num;
            Console.WriteLine("square = " + sq);
        }
        static void Main(string[] args)
        {
            square(); // calling the method display
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
