using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3];
            arr[0] = "amit";
            arr[1] = "raj";
            arr[2] = "dilip";
            //display the array elements
            foreach (string val in arr)
            {
                Console.WriteLine("num=" +val);
                Console.ReadLine();
            }
        }
    }
}
