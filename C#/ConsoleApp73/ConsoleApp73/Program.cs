using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("enter num");
            n1 = Convert.ToInt32(Console.ReadLine());
            int result = facto(n1);
            Console.WriteLine("fact" + result);
            Console.ReadKey();
        }
        static int facto(int num)
        {
            int fact = 1, i;
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
        
    

