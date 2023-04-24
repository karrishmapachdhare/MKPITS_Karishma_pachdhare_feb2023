using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_modifier
{
    public class person
    {
        string name;
        string address;
        protected void getPersonDats(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class Student : person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {

            // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class
            p1.displayPersonData("honey", "nagpur");
            p1.getStudentData(111, 999);
            p1.displayStudentData();
            p1.displayPersonData();
        }
     
    }
}
