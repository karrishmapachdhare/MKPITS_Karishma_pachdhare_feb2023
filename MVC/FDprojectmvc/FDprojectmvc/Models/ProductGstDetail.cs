namespace FDprojectmvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductGstDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductGstDetail()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Gst_Id { get; set; }

        [StringLength(500)]
        public string Gst_Detail_Name { get; set; }

        public decimal? CGST { get; set; }

        public decimal? SGST { get; set; }

        public decimal? IGST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
