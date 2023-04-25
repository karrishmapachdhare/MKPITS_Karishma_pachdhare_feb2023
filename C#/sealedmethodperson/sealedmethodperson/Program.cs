using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedmethodperson
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student:person

    {
        public sealed override void display()
        {
            Console.WriteLine("hello from student");
        }
    }
    class poststudent : student
    {
        public void pshow()
        {
            Console.WriteLine("hello from person");

        }

    }
    class Program
    {
       public static void Main(string[] args)
        {
            poststudent p = new poststudent();
            p.display();
            p.pshow();
        }
    }
}
