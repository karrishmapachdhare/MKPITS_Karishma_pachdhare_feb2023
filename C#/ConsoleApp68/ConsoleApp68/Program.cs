using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("calling the method");
            int result= calculatesquare();
            Console.WriteLine("square=" +result);
        }
        static int calculatesquare()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;

            return square;
            


        }        
    }
}
