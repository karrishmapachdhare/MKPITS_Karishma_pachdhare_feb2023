namespace FDprojectmvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Products")]
    public partial class Product1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product1()
        {
            InvoiceDetails1 = new HashSet<InvoiceDetails1>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Id { get; set; }

        public int? ProductTypeId { get; set; }

        [StringLength(500)]
        public string Product_Name { get; set; }

        public int? price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetails1> InvoiceDetails1 { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
