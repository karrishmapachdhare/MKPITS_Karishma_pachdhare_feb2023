
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to accept radius of a circle and display the are and circ.
            int radius;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("area = " + area);
            float circ = 2 * 3.14f * radius;
            Console.WriteLine("circ = " + circ);
            Console.ReadLine();

        }
    }
}