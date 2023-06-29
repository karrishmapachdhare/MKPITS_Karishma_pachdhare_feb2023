using Microsoft.AspNetCore.Mvc;

namespace signupmvc.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
