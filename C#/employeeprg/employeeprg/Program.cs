﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace employeeprg
{
    class person
    {
        public string name;
        public string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
    public void displaypersondata()
        {
            Console.WriteLine("empname " + name);
            Console.WriteLine("emp addres " + address);

        }


    }
    //inheriting a new child class from person class
    class employee : person
    {

        public int empno;
        public int salary;
        public void getemployeedata(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
            public void displayempoyeedata()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("salary" + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
         employee emp = new employee();
            emp.getpersondata("amit", "sadar");
            emp.getemployeedata(333,9999);
            emp.displayempoyeedata();
            emp.displaypersondata();
        }
    }
}
