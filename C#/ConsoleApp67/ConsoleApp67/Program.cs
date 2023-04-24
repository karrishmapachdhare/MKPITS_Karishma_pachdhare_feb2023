using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Program
    {
        public static void Main()
        {
           Console.WriteLine("calling to the method display");
            display();
            Console.WriteLine("again calling display");
            display();
            // creating defined method display 
            static void dispaly() ;
            {
                Console.WriteLine("hello word");
            }
        }
        
    }
}
