using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    interface IAccount
    {
        interface interface1
        {
            void method1();

        }
        class class1 : interface1

        {
            public void method1()
            {
                Console.WriteLine("hello from method");

            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                interface1 a1 = new class1();
                a1.method1();
            }
        }

    }

}

