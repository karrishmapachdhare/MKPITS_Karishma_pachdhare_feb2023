using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfieldex
{
    class Account
    {
        public int actno;
        public string name;
        public static float roi = 4.5f;
        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("actno" + actno);
            Console.WriteLine("name" + name);
            Console.WriteLine("rate of Instrest" + roi);
        }
    }


     class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123, "kajal");
            Account a2 = new Account(22, "yogesh");
            Account.roi = 33.4f;
            a1.display();
            a2.display();
        }
    }
}
