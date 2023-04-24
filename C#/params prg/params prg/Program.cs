using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_prg
{
    internal class Program
    {
        static void display(params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];

            }
            Console.WriteLine("sum = " + sum);

        }
        static void Main(string[] args)
        {
            display(2, 3, 4);
            Console.ReadKey();

        }
    }
}

