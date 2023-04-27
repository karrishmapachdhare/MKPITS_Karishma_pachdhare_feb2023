using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello f#";
            string s2 = s1.Replace('F', 'C');
            Console.WriteLine(s2);
        }
    }
}
