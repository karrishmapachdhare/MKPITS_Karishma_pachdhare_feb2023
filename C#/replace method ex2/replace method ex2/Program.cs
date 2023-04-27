using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace_method_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#, Hello .Net, Hello Javatpoint";
            string s2 = s1.Replace("Hello", "Cheers");
            Console.WriteLine(s2);
        }
    }
}
