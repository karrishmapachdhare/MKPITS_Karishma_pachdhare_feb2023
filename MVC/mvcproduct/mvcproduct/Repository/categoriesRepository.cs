using mvcproduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcproduct.Repository
{
    public class categoriesRepository
    {
        private readonly fendhlEntities1 fpe;
        public categoriesRepository()
        {
            fpe = new fendhlEntities1();
        }

        public IEnumerable<SelectListItem> GetAllCategories()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (
                                   from obj in fpe.ProductCategories
                                   select new SelectListItem
                                   {
                                       Text = obj.Product_type_Name,
                                       Value = obj.Product_Category_Id.ToString(),
                                       Selected = true
                                   }
                               ).ToList();

        }

    }
}