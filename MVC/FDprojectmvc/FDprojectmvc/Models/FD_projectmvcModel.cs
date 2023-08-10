using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FDprojectmvc.Models
{
    public partial class FD_projectmvcModel : DbContext
    {
        public FD_projectmvcModel()
            : base("name=FD_projectmvcModel")
        {
        }

        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceDetails1> InvoiceDetails1 { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductGstDetail> ProductGstDetails { get; set; }
        public virtual DbSet<Product1> Products1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Customer_Name)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Customer_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.CGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.SGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.IGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.CGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.SGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.IGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Total_Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.Customer_Name)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.Customer_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.CGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.SGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.IGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.CGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.SGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.IGST_Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceDetails1>()
                .Property(e => e.Total_Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.Product_type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.ProductCategory)
                .HasForeignKey(e => e.ProductTypeId);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products1)
                .WithOptional(e => e.ProductCategory)
                .HasForeignKey(e => e.ProductTypeId);

            modelBuilder.Entity<ProductGstDetail>()
                .Property(e => e.Gst_Detail_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductGstDetail>()
                .Property(e => e.CGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProductGstDetail>()
                .Property(e => e.SGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProductGstDetail>()
                .Property(e => e.IGST)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product1>()
                .Property(e => e.Product_Name)
                .IsUnicode(false);
        }
    }
}
