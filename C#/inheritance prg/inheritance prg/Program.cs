﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_prg
{
    //creating a base class person
    class person
    {
        public string name;
    }
    //creating a derieved class student
    class studnet:person
    {
        public int rno;
        
    }
    
        
     class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 111;
            s.name = "rajesh";
            Console.WriteLine("rno " + s.rno);
            Console.WriteLine("name " + s.name);
        }
    }
}
