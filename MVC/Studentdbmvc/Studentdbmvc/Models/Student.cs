using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Studentdbmvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public int MobNo { get; set; }
        public string Email { get; set; }
    }
}