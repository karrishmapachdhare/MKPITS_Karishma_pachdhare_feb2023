using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_having_fields_and_methods
{
    class student

    {
        int rno;
        string name;
        //creating member functions
        public void getdata()
        {
            rno = 123;
            name = "amit";
        }
        public void displaydata()
        {
            Console.WriteLine("rno" + rno);
            Console.WriteLine("name" + name);
        }
    
        static void Main(string[] args)
        {
            student stud1= new student();
            stud1.displaydata();
            Console.ReadKey();
        }
    }
}
