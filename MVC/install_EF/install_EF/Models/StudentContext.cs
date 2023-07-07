using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace install_EF.Models
{
    public class StudentContext:DbContext
    { 
        //creating a constractor and calling the base class constractor and passing the database name

    public StudentContext():base("StudentDatabase")
        {

        }
       // creating property
       public DbSet<Student> Students { get; set; }
    }
}