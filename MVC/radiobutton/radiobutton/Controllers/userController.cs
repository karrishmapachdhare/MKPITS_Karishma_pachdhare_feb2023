using Microsoft.AspNetCore.Mvc;

namespace radiobutton.Controllers
{
    public class userController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
