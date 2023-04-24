using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length and breath");
            int length, breath, area;
            length=Convert.ToInt32(Console.ReadLine());
            breath = Convert.ToInt32(Console.ReadLine());
            area = length * breath;
            Console.WriteLine("area of a rectangle is" + area);
            Console.ReadKey();      
        }
    }
}
