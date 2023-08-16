using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FDprojectmvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private readonly fendhlEntities fpe;
        public HomeController()
        {
            fpe = new fendyl_projectbEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            var objCategoryRepository = new CategoriesRepository();
            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>>(
                              objCategoryRepository.GetAllCategories());

            return View(objMultipleModels);
        }
    }
}