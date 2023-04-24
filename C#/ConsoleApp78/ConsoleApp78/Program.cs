using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    internal class Program
    {
        static void Main()
      {

            for (int outcounter = 1; outcounter <20; outcounter++)
            {
                int num = outcounter;
                int flag = 0;
                for (int counter = 2; counter < num; counter++)
                {
                    if (num % outcounter == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    Console.WriteLine(num + "is a prime no");
                }
            }
            Console.ReadLine();
            
        }
    }
}
