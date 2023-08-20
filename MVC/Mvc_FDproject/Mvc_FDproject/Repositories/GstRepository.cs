using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_FDproject.Models;
using Mvc_FDproject.Repositories;
using Mvc_FDproject.ViewModels;

namespace Mvc_FDproject.Repositories
{
    public class GstRepository
    {
        private readonly fendhlEntities1 fpe;
        public GstRepository()
        {
            fpe = new fendhlEntities1();
        }
        public IEnumerable<SelectListItem> GetGstDetails()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in fpe.ProductGstDetails
                                    select new SelectListItem
                                    {
                                        Text = obj.CGST.ToString(),
                                        Value = obj.CGST.ToString(),
                                        //   Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}


    
