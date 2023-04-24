using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example of foreach loop
            //create an array of 5 element
            string[] num = new string[3];

            num[0] = "akash";
            num[1] = "rahul";
            num[2] = "abhimanyu";
            //using foreach loop to iterate over the elements of an array
            foreach (string i in num)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }
    }
}
