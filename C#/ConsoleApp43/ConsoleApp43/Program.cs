﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int res = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                Console.ReadLine();

            }
        }
    }
}
