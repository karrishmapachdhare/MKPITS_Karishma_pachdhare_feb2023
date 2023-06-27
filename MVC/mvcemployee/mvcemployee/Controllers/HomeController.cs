using Microsoft.AspNetCore.Mvc;
using mvcemployee.Models;
using System.Diagnostics;

namespace mvcemployee.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employe e)
        {
            ViewBag.name = e.EmpName;
            ViewBag.bsal = e.BasicSalary;
            if (e.Hra == true)
            {
                e.Result1 = e.BasicSalary * 0.25;
                ViewBag.result1 = e.Result1;
            }
            if (e.Da == true)
            {
                e.Result2 = e.BasicSalary * 0.45;
                ViewBag.result2 = e.Result2;
            }
            if (e.Ta == true)
            {
                e.Result3 = e.BasicSalary * 0.15;
                ViewBag.result3 = e.Result3;
            }
            ViewBag.totalsal = e.Result1 + e.Result2 + e.Result3;
            ViewBag.total = e.Totalsal;
            return View();
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        
    }
}