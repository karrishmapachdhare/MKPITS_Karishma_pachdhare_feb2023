using Microsoft.AspNetCore.Mvc;
using proj1.Models;

namespace proj1.Controllers
{
    public class CalcutateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
          [HttpPost]
        public IActionResult Index(Calculate c)
        {
            ViewBag.num1 = c.num1;
            ViewBag.num2 = c.num2;
            if (c.add == true)
            {
                c.result1 = c.num1 + c.num2;
                ViewBag.result1 = c.result1;
            }
            if (c.substraction == true)
            {
                c.result2 = c.num1 - c.num2;
                ViewBag.result2 = c.result2;
            }
            if(c.multiply == true)
            {
                c.result3= c.num1 * c.num2;
                ViewBag.result3 = c.result3;
            }
            return View();
        }
    }
}
