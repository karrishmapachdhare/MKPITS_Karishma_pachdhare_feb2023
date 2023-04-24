using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter char");
            if (ch == 'a' || ch == 'i' || ch == 'e' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("char is vowel");
            }
            else if (ch >='a' && ch<='z')
            {
                Console.WriteLine("char is consonant");
            }
            else
            {
                Console.WriteLine("It is not character");
            }
            Console.ReadLine();
        }
    }
}
    




   

