using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());

                if (age <= 18 || age >= 50)
                {
                    throw new Exception("Enter the proper age");
                }
                else
                {
                    Console.WriteLine("Your age is" + age);
                }
            } 
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());

            }
            Console.WriteLine("bye");
        }
    }
}
