using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Endswith
{
    internal class Program
    {
       public  static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "c#";
            string s3 = "llo";
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
        }
    }
}
