using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_5_students_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] std = new string[5];
            Console.WriteLine("enter students name");
            std [0] = "karishma";
            std [1] = "diksha";
            std [2]= "tina";
            std[3] = "siddhi";
            std[4] = "kajal";
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(std[i]);

            }
            Console.ReadKey();
        }
    }
}
