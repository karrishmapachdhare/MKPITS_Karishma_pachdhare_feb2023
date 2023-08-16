using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_FDproject.Models;
using Mvc_FDproject.Repositories;
using Mvc_FDproject.ViewModels;
namespace Mvc_FDproject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
            private readonly fendhlEntities1 fpe;
            public HomeController()
            {
                fpe = new fendhlEntities1();
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