using System;
//system is a namespace
//namespace is a unit to group related classes, packages

namespace HelloProgram
{
    class Program
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square of a number is " + square);
            Console.ReadKey();
        }
    }
}