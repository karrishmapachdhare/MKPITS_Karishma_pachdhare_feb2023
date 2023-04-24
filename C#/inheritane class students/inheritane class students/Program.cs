using inheritane_class_students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritane_class_students
{
    class person
    {
        public int rno;
        public string name;
        public int age;
        public string address;
        public string city;
        public string emailid;
        public string mobno;
        public string branch;
        public void getdata(int rno, string name, int age, string address, string city, string emailid, string mobno,string branch)
        {
            this.rno = rno;
            this.name = name;
            this.age = age;
            this.address = address;
            this.city = city;
            this.emailid = emailid;
            this.mobno = mobno;
            this.branch = branch;
        }
    }
    public void display()

    {
        Console.WriteLine("rno");
        Console.WriteLine("name");
        Console.WriteLine("age");
        Console.WriteLine("address");
        Console.WriteLine("city");
        Console.WriteLine("emailid");
        Console.WriteLine("mobno");
        Console.WriteLine("branch");
    }

     class student:person

     {
        int studid;
        public void getdata(int studid,string rno,string name,int age,string address,string city,string emailid,string mobno,string branch)
        {
            this. studid = studid;
            getdata(rno,"name",age,"");


        }
        public void display()//function overloading

        {
            base.display();
            Console.WriteLine("custid" + custid);
        }
    }
    internal class Program

            getdata("567", "rahul", 23, "housing board colony", "bilaspur", "rahullanjhekar@gmail.com", "8765430123", "cs");

        }
     }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
