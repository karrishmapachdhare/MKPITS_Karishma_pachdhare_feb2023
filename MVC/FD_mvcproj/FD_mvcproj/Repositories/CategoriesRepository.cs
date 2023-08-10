using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FD_mvcproj.Models;

namespace FD_mvcproj.Repositories
{
    public class CategoriesRepository
    {

        private readonly fendhlEntities fpe;
        public CategoriesRepository()
        {
            fpe = new fendhlEntities();
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
            return objSelectListItems;

        }

    }
}