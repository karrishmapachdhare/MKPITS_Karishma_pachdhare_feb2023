using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_FDproject.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string Product_Name { get; set; }
        public int Product_Category_ID { get; set; }

        public decimal Product_Price { get; set; }
    }
}