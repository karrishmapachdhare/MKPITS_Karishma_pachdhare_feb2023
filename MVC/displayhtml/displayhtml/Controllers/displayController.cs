using displayhtml.Models;
using Microsoft.AspNetCore.Mvc;

namespace displayhtml.Controllers
{
    public class displayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public class HomeController : Controller
        {
            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Index(FormCollection fc,    user um)
            {
                if (ModelState.IsValid)
                {
                    um.UserName = fc["UserName"];
                    return View(um);
                }
                else
                {
                    return View();

                }

            }

        }

    }

}

