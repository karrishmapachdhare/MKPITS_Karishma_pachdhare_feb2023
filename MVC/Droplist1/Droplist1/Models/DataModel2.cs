using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Droplist1.Models
{
    public partial class DataModel2 : DbContext
    {
        public DataModel2()
            : base("name=DataModel2")
        {
        }

        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblState>()
                .HasMany(e => e.tblCities)
                .WithRequired(e => e.tblState)
                .WillCascadeOnDelete(false);
        }
    }
}
