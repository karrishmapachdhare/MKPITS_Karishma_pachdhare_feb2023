using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to accept a number and print the square of that number
            int num;
            Console.WriteLine("enter number ");
            num = Convert.ToInt32(Console.ReadLine()); //toint32 method will convert string to integer
            int square = num * num;
            Console.WriteLine("square = " + square);
            Console.ReadLine();


        }
    }
}


