using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyrefereneprg
{
    internal class Program
    {
        static void Main()
        {
            int radius;
            float area, cir;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 0.0f;
            cir = 0.0f;
            calculatearea(radius, ref area, ref cir);
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference" + cir);
        }
        static void calculatearea(int radius, ref float a, ref float c);
        {
        a= 3.14f* r* r;
        c=2*3.14f*r;
        }
    }
}
