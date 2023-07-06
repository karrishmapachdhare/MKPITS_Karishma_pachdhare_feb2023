using Studentdbmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studentdbmvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //1.******************** Display All Student List Index Page***************
        public ActionResult Index()
        {
            ViewBag.Studentdb = "Collage Student List Page";
            StudentDBHandler handler = new StudentDBHandler();
            ModelState.Clear();
            return View(handler.GetStudent());
            
            
            
            return View();
        }

    }
}