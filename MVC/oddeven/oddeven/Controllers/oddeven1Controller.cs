using Microsoft.AspNetCore.Mvc;
using oddeven.Models;

namespace oddeven.Controllers
{
    public class oddeven1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(oddeven1 oe)
        {
            int num = oe.num;
            string res = "";
            if(num%2==0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }
            return View();

        }

    }
}
