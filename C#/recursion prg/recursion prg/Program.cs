using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, primeNo;
            Console.WriteLine("input any positive number:");
            n1=Convert.ToInt32(Console.ReadLine());
            
            primeNo = checkForPrime(n1, n1 / 2);//call the funtion CeckForPrime

            if (primeNo == 0)
            {
                Console.WriteLine("the number{0} is a prime number.\n\n", n1);

                else

                    Console.WriteLine(" The number {0} is not a prime number. \n\n", n1);
               
                return 0;
            }

            static int checkForPrime(int n1, int i)
            {
                if (i == 1)
                {
                    return 1;
                }
                else
                {
                    if (n1 % i == 0)
                        return 0;

                    else
                        return checkForPrime(n1, i - 1);//calling the function
                }
        }
    }
}
