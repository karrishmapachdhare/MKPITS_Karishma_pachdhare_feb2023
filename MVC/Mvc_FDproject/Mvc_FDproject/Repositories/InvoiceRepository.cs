using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_FDproject.Models;
using Mvc_FDproject.ViewModels;


namespace Mvc_FDproject.Repositories
{
    public class InvoiceRepository
    {
        private readonly fendhlEntities1 fpe;
        public InvoiceRepository()
        {
            fpe = new fendhlEntities1();
        }

        //method to add records inside invoice table

        public bool AddInvoice(InvoiceViewModel invoiceViewModel)
        {
            try
            {
                InvoiceDetail objInvoice = new InvoiceDetail()
                {
                    Customer_Name = invoiceViewModel.Customer_Name,
                    Customer_Contact = invoiceViewModel.Customer_Contact,

                    Product_Category_Id = invoiceViewModel.Product_Category_ID,
                    Product_Id = invoiceViewModel.Product_ID,

                    Residential_Type_Id = invoiceViewModel.Residential_Type_ID,
                    Invoice_Date = Convert.ToDateTime(invoiceViewModel.Invoice_Date),

                    //  Invoice_Date =invoiceViewModel.Invoice_Date,
                    Quantity = invoiceViewModel.Quantity,
                    Price = invoiceViewModel.Price,
                    CGST = invoiceViewModel.CGST,
                    SGST = invoiceViewModel.SGST,
                    IGST = invoiceViewModel.IGST,
                    CGST_Value = invoiceViewModel.CGST_Value,
                    SGST_Value = invoiceViewModel.SGST_Value,
                    IGST_Value = invoiceViewModel.IGST_Value,
                    Total_Amount = invoiceViewModel.Total_Amount,



                };
                fpe.InvoiceDetails.Add(objInvoice);
                fpe.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

