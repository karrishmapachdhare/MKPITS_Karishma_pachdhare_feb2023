using connectionmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace connectionmvc.Controllers
{
    public class ItemController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 1. *********** Add New Item ***********
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                Itemdbhandlarcs db= new Itemdbhandlarcs();
                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();

        }

    }

}
