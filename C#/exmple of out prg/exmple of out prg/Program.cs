using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmple_of_out_prg
{
    internal class Program
    {
        static void display(params int[] num)
        {
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

        }
        static void Main(string[] args)
        {
            display(2, 3, 4);
            Console.ReadKey();
        }
    }
}
