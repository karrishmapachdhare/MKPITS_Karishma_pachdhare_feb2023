using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2diamention_arrary
{

    class Program
    {


        static void Main()
        {
            int[,] arr = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.WriteLine("enter number");
                        arr[row, col] = Convert.ToInt32(Console.ReadLine());
                        arr[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                //code to display value
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.WriteLine(arr[row, col] + "\t");
                    }
                    Console.WriteLine();

                }

            }
        }

    }

}

