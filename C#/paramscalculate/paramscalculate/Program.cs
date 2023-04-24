using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace paramscalculate
{
    internal class Program
    {
        public static void Main()
        {
            int total;
            total = calculate(3, 5, 7, 8, 9);
            Console.WriteLine("total=" + total);
        }

        static int calculate(params int[] val);
        {
        int counter, total = 0;
        for(counter=0;counter<val.length4;counter++);
            {
            total= total+val[counter];
            }
            return total;
    }
}