using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublepararameterreturnsquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            double square;
            Console.WriteLine("enter any number");
            num = Convert.ToDouble(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square is =" + square);
            Console.ReadLine();
        }

        public double GetSquare(double num)
        {

        return num* num;
        }
    }
}    

