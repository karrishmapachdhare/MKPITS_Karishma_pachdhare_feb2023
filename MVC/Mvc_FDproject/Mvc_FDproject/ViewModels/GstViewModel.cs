using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_FDproject.ViewModels
{
    public class GstViewModel
    {
        public int Product_Gst_ID { get; set; }
        public string Gst_Deatil_Name { get; set; }
        public int CGST { get; set; }
        public int SGST { get; set; }
        public int IGST { get; set; }
    }
}