using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outparametercircumference
{
    internal class Program
    {
        static void Main()
        {
            int radius;
            float area, cir;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            calculatearea(radius, out area, out cir);
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference" + cir);
        }

        static void calculatearea(int r, out float a, out int c)
        {
            a= 3.14f * r * r;
            c = 2 * 3.14f * r;

        }
    }
}
