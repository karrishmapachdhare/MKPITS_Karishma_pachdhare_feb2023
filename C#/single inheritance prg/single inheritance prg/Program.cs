using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_prg
{
    public class person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("address" + address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks:" + marks);
        }
    }
     class TestInheritance
    {
        
        public static void Main(string[] args)
        {
            student p1 = new student();//creating object of child class
            p1.getPersonData("kajal", "nagpur");
            p1.getStudentData(1999, 654);
            p1.displayStudentData();
            p1.displayPersonData();
        }
    }
}
