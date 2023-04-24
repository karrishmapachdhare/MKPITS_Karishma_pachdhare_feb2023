using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace single_level_with_overloading
{
    class person
    {
        string name;
        string address;
        int age;
        string mobno;
        public void getdata(string name, string address,int age,string mobno )
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobno = mobno;
        }
        public void display()
        {
            Console.WriteLine("name"+name);

            Console.WriteLine("address"+address);
            Console.WriteLine("age" + age);
            Console.WriteLine("mobno"+mobno); 
        }
    }

      class customer:person
    {
        public int custid;
        public void getdata(int custid,string name,string address, int age,string mobno) //funtion oerloading
        {
            this.custid = custid;
            getdata(name,address,age,mobno); 


        }
          public void display()//function overloading

        {
            base.display();
            Console.WriteLine("custid" + custid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(123, "yogesh", "nagpur",20,"8390873914");
            cust.display();
            Console.ReadKey();
        }

    }
}
