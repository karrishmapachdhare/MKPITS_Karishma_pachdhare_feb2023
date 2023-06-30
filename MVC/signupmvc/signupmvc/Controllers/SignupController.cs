using Microsoft.AspNetCore.Mvc;
using signupmvc.Models;

namespace signupmvc.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Signup su)
        {
            ViewBag.username = su.username;
            ViewBag.Gender = su.gender;

          

            ViewBag.subject1 = null;
            ViewBag.subject2 = null;
            if (su.subject1 == true)
            {
                ViewBag.subject1 = "dotnet";
            }
            if (su.subject2 == true)

            {
                ViewBag.subject2 = "java";
            }
            var ct = su.getcitytype;
            ViewBag.city = ct.ToString();

            return View();

        }

    }

}
            






          