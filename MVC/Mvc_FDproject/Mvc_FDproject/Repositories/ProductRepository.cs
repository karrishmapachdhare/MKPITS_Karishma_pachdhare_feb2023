using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mvc_FDproject.Models;
using Mvc_FDproject.Repositories;
using Mvc_FDproject.ViewModels;
using System.Web.Mvc;

namespace Mvc_FDproject.Repositories
{
    public class ProductRepository
    {
        private readonly fendhlEntities1 fpe;
        public ProductRepository()
        {
            fpe = new fendhlEntities1();
        }
        public IEnumerable<SelectListItem> GetAllProducts()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in fpe.Products
                                    select new SelectListItem
                                    {
                                        Text = obj.Product_Name,
                                        Value = obj.Product_Id.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}
