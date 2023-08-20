using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_FDproject.ViewModels
{
    public class InvoiceViewModel
    {
        public int Invoice_Detail_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Contact { get; set; }
        public int Product_Category_ID { get; set; }
        public int Product_ID { get; set; }
        public int Residential_Type_ID { get; set; }

        public DateTime Invoice_Date { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public Decimal CGST { get; set; }
        public Decimal SGST { get; set; }
        public Decimal IGST { get; set; }

        public Decimal CGST_Value { get; set; }
        public Decimal SGST_Value { get; set; }
        public Decimal IGST_Value { get; set; }

        public Decimal Total_Amount { get; set; }

    }
}