using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            foreach (int value in num)
            {
                Console.WriteLine(value); //1
                Console.ReadLine();
            }

        }
    }
}
