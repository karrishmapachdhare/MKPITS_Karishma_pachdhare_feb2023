﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeparameter
{
    class student
    {
        int rno;
        string name;
        //creating member functions
        public void getdata(int r, string n)
        {
            rno = r;
            name = n;
        }
        public void displaydata()
        {

            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            student stud1 = new student();
            Console.WriteLine("enter rno");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            stud1.getdata(rno, name);
            stud1.displaydata();
        }
    }
}
        }
    }
}
