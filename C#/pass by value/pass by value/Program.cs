using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value
{
    internal class Program
    {
        static void display(int num)
        {
            num++;
            Console.WriteLine("num inside method " + num);

        }
        static void Main(string[] args)
        {
            int num = 5;
            display(num);

            Console.WriteLine("num inside main" + num);
            Console.ReadKey();
        }
    }
}
