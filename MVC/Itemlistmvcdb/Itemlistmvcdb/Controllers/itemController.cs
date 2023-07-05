using Itemlistmvcdb.Models;
using System.Web.Mvc;

namespace Itemlistmvcdb.Controllers
{
    public class itemController : Controller
    {
        // GET: item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            itemdbhandler IHandler = new itemdbhandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }
        // 1. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                itemdbhandler db = new itemdbhandler();

                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }
        // 3. *********** Update Item Details ***********
        [HttpGet]
        public ActionResult Edit(int id)
        {
            itemdbhandler ItemHandler = new itemdbhandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]

        public ActionResult Edit(int id, ItemModel iList)
        {
            try
            {
                itemdbhandler ItemHandler = new itemdbhandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        // 4. *********** Delete Item Details ***********
        public ActionResult Delete(int id)
        {
            try
            {
                itemdbhandler ItemHandler = new itemdbhandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        public ActionResult Details(int id)
        {
            itemdbhandler ItemHandler = new itemdbhandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }

    }
}