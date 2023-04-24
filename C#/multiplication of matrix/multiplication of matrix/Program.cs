using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 11, 22 }, { 13, 4 } };
            int[,] arr2 = { { 12, 6 }, { 15, 7 } };
            int[,] arr3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] * arr2[i, j];
                }



            for (int i = 0; i < 2; i++)

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr3[i, j] + "\t");

                    Console.WriteLine();

                    Console.ReadKey();
                }
        }
    }

}
    

    

