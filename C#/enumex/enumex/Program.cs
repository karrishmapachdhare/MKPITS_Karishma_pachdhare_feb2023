using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumex
{
    //making a enumerator "month"
    enum month
    {
        //following are the data members
        jan,
        feb,
        mar,
        apr,
        may
    }
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            //getting the integer values of data members
            Console.WriteLine("the value of jan in month"+"enum is"+(int)month.jan);
            Console.WriteLine("the value of feb in month" + "enum is" + (int)month.feb);
            Console.WriteLine("the value of mar in month" + "enum is" + (int)month.mar);
            Console.WriteLine("the value of apr in month" + "enum is" + (int)month.apr);
            Console.WriteLine("the value of may in month" + "enum is" + (int)month.may);
        }

    }
}
