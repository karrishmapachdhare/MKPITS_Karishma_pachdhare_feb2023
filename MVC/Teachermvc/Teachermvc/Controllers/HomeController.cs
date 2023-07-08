using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teachermvc.Models;

namespace Teachermvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.Teachers = teacher.GetTeachers();
            mymodel.Students = student.GetStudents();
            return View(mymodel);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}