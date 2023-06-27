using Microsoft.AspNetCore.Mvc;
using signupform.Models;

namespace signupform.Controllers
{
    public class signupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public  IActionResult Index(signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            ViewBag.email = u.email;
            ViewBag.gender = u.gender;
            ViewBag.subject1 = null;
            ViewBag.subject2 = null;
            if (u.subject1 == true)
            {
                ViewBag.subject1 = "dotnet";
            }
            if (u.subject2 == true)
            {
                ViewBag.subject2 = "java";
            }

            return View();
        }

    }
}

