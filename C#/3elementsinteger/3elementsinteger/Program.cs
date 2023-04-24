using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3elementsinteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isfound = false;
            int[] arr = { 1, 2, 3 };
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int counter = 0; counter < arr.Length; counter++)
            {
                if (arr[counter] == num)
                {
                    isfound = true;
                    break;
                }
            }
            if (isfound == true)
            {
                Console.WriteLine(num + "found in array");
            }
            else
            {


                Console.WriteLine("not found");
                Console.ReadKey();
            }
        }

    }

}

    

