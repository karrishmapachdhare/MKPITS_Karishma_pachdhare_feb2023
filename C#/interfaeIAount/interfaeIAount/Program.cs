using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaeIAount
{
    interface IAccount
    {
        string deposit(int amt);
    }
    abstract class Account:IAccount
    {
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string showbalane()
        {
            return "bal is" + balance.ToString();

        }

    }
    class saving : Account
    {
        int intrest = 500;
        public override string deposit(int amt) 
        {
            balance = balance + amt + intrest;
            return "amount deposit with intrest bal is" + balance;

        }

    }
    class current:Account
    {
        public override string deposit(int amt)
        {
            balance = balance + amt;
            return "ammount deposite without intrest bal is" + balance;
        }
    }
            
    class Program
    {
        static void Main(string[] args)
        {
            Account act = null;
            string acttype;
            Console.WriteLine("enter account type");
            acttype = Console.ReadLine();
            Console.WriteLine("enter amount to be ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "currrent")
            {
                act = new current();
            }
            string res = act.deposit(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalane());
        }
    }
}
    

