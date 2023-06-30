using Microsoft.AspNetCore.Mvc;
using signupmvc.Models;
using System.Diagnostics;

namespace signupmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Signup su)
        {
            ViewBag.uname = su.username;
            ViewBag.Gen = su.gender;

            var ct = su.getcitytype;
            ViewBag.city = ct.ToString();

            ViewBag.subject1 = null;
            ViewBag.subject2 = null;
            if (su.subject1 == true)
            {
                ViewBag.subject1 = "dotnet";
            }
            if (su.subject2 == true)

            {
                ViewBag.subject = "java";
            }

            return View();
        }
            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}