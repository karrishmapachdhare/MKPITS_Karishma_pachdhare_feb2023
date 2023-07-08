using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Productmvc.Models
{
    public partial class ProductModel1 : DbContext
    {
        public ProductModel1()
            : base("name=ProductModel1")
        {
        }

        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblCategory1> tblCategory1 { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProduct1> tblProducts1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCategory>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCategory1>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblCategory1)
                .WillCascadeOnDelete(false);
        }
    }
}
