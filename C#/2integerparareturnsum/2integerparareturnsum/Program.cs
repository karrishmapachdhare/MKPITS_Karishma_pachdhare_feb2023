using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2integerparareturnsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = addition(num1, num2);
            Console.WriteLine("addition=" + result);
            Console.ReadLine();
        }
        static int addition(int num1, int num2);
        {
            int result = num1+num2;
            return result;
        }
           


    
}
