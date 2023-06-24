using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
