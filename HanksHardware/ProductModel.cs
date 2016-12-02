/// <summary>
/// Hanks Hardware	
/// Created By David McNiven
/// Student	# 200330143
/// Created On December 1st, 2016
/// A mock computer ordering application using a database and plaintext save files
/// </summary>
namespace HanksHardware
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
