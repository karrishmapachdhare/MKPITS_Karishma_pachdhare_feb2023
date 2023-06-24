using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
