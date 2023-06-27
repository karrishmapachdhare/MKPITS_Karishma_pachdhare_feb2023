using helpercheckbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace helpercheckbox.Controllers
{
   
    public class usermodelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(usermodel um)
        {
            ViewBag.Tea=um.Tea.ToString();
            ViewBag.loundry=um.loundry.ToString();
            ViewBag.Breakfast=um.Breakfast.ToString();
            ViewBag.Locked=um.Locked.ToString();
            ViewBag.Table=um.Table.ToString();
            return View();
        }
    }
}
