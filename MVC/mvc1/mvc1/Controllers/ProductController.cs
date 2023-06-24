using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
