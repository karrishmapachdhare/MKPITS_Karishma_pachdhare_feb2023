using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advantages_of_inheritance
{
    public class employee
    {
        public float salary = 40000;
    }
    public class programmer:employee
    {
        public float bonus = 10000;

    }
     class TestInheritance
    {
       public static void Main(string[] args)
        {
            programmer p1 = new programmer();
            Console.WriteLine("salary:" + p1.salary);
            Console.WriteLine("bonus:"+p1.bonus);
        }
    }
}
