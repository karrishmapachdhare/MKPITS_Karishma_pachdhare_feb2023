﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Program
    {
        
            static int square()
            {
                int num = 5;
                int sq = num * num;
                return sq;
            }
            static void Main(string[] args)
            {

                int res = square(); // calling the method display
                Console.WriteLine("square " + res);
                Console.ReadLine();
            }
        
    }

}
