﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    internal class Program
    {
        
            static int square(int num)
            {

                int sq = num * num;
                return sq;
            }
            static void Main(string[] args)
            {
                int num = 5;
                int res = square(num); // calling the method display
                Console.WriteLine("square " + res);
                Console.ReadKey();
            }
        }
    }


