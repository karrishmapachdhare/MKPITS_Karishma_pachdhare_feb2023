using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello c#";
            int index=s1.IndexOf(s1);
            Console.WriteLine(index);
        }
    }
}
