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
        [HttpGet]

        public JsonResult getAllProducts(int catid)
        {

            fpe.Configuration.ProxyCreationEnabled = false;
            List<Product> ProductList = fpe.Products.Where(x => x.Product_Id == catid).ToList();
            return Json(ProductList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]

        public JsonResult getGstId(int catid)
        {

            fpe.Configuration.ProxyCreationEnabled = false;
            List<ProductCategory> ProductList = fpe.ProductCategories.Where(x => x.Product_Category_Id == catid).ToList();
            return Json(ProductList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]

        public JsonResult getGstDetails(int gstid)
        {

            fpe.Configuration.ProxyCreationEnabled = false;
            List<ProductGstDetail> ProductList = fpe.ProductGstDetails.Where(x => x.Product_Gst_Id == gstid).ToList();
            return Json(ProductList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getPrice(int prodid)
        {

            fpe.Configuration.ProxyCreationEnabled = false;
            List<Product> ProductList1 = fpe.Products.Where(x => x.Product_Id == prodid).ToList();
            return Json(ProductList1, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(InvoiceViewModel objInvoiceViewModel)
        {
            InvoiceRepository objInvoiceRepository = new InvoiceRepository();
            bool isStatus = objInvoiceRepository.AddInvoice(objInvoiceViewModel);
            string SuccessMessage = String.Empty;

            if (isStatus)
            {
                SuccessMessage = "Your invoice Has Been Successfully Placed.";
            }
            else
            {
                SuccessMessage = "There Is Some Issue While Placing invoice.";
            }
            return Json(SuccessMessage, JsonRequestBehavior.AllowGet);
        }

    }
}