using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_prg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 8, 10, 12, 14, 16 };
            Console.WriteLine("enter a number to search for;");
            int target=int.Parse(Console.ReadLine());


            int result = binarysearch(number, target);
            if (result == -1)
            {
                Console.WriteLine("The number{0} was not found.", target);
            }
            else
            {
                Console.WriteLine("The number {0} was found at index {1}.", target, result);
            }
            Console.ReadLine();
            }
        static int binarysearch(int[] number, int target)
        {
            int left = 0;
            int right =number.Length-1;
            while (left <=right)
            {
                int middle=(left+right)/2;
                if (number[middle] == target)
                {
                    return middle;
                }

                else if (number[middle]<target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            
            }
            return -1;
          
        }

        
    }
}
