using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using connectionItem.Models;
namespace connectionItem.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.Itemlist = "Computer Shop Item List Page";
            ItemDBhandler Ihandler = new ItemDBhandler();
            ModelState.Clear();
            return View(Ihandler.GetItemList());

        }
        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                ItemDBhandler ItemHandler = new ItemDBhandler();
                if (ItemHandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            /* }
            catch { return View(); }*/





           
        }
    }
}