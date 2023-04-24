using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to accept a age from the user and print whether eligible to vote or not
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("not elegible to vote");
            }
            else
            {
                Console.WriteLine("eligible to vote");
            }
        }
    }
}
