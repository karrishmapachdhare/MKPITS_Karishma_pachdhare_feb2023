﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);

                i++;
                if (i <= 10)
                    continue;
                else
                    break;
            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
