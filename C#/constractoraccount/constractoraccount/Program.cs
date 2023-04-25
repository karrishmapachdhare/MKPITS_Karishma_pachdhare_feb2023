using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constractoraccount
{
    class Account
    {
        public int actno;
        public string name;
        public static int count;
        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
        }

        public void display()
        {
            Console.WriteLine("actno" + actno);
            Console.WriteLine("name" + name);
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123, "kajal");
            Account a2 = new Account(22, "yogesh");
            
            a1.display();
            a2.display();
            Console.WriteLine("no of object"+Account.count);
        }
    }
}


