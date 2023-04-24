using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3row_3coloum
{
    class Program
    {
        static void Main()
        {
            //creating a num array of 3 rows and 3 colums
            // int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int[,] num = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("enter num");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //display the values of array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.ReadKey();

            }

        }

    }

}
    

