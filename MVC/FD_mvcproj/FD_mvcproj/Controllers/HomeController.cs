using FD_mvcproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FD_mvcproj.Repositories;
using FD_mvcproj.ViewModels;


namespace FD_mvcproj.Controllers
{
    public class HomeController : Controller
    {
      
            private readonly fendhlEntities fpe;
            public HomeController()
            {
                fpe = new   fendhlEntities();
                
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