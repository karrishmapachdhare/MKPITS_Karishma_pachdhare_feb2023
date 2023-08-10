namespace FDprojectmvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Invoice_Detail_Id { get; set; }

        [StringLength(500)]
        public string Customer_Name { get; set; }

        [StringLength(15)]
        public string Customer_Contact { get; set; }

        public int? Product_Category_Id { get; set; }

        public int? Product_Id { get; set; }

        public int? Residential_Type_Id { get; set; }

        public DateTime? Invoice_Date { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Price { get; set; }

        public decimal? CGST { get; set; }

        public decimal? SGST { get; set; }

        public decimal? IGST { get; set; }

        public decimal? CGST_Value { get; set; }

        public decimal? SGST_Value { get; set; }

        public decimal? IGST_Value { get; set; }

        public decimal? Total_Amount { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual Product Product { get; set; }
    }
}
