using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter number1");
            num1 = Console.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Console.ToInt32(Console.ReadLine());
            Console.WriteLine("display other method");
            Result = addition(num1, num2);
            Console.WriteLine("addition=" + result);
            Console.WriteLine("calling substraction");
            Result = substraction(num1, num2);
            Console.WriteLine("substraction=" + result);
            Console.ReadLine();
        }
        static int addition(int num1, int num2);
        {
        int result = n1 + n2;
        resturn result;
        }
    static interface substraction(int n1, int n2);
    {
        int result = n1 - n2;
    return result;

}
    

