namespace FinalProjectCSharp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Band> Bands { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>()
                .Property(e => e.BandName)
                .IsUnicode(false);

            modelBuilder.Entity<Band>()
                .Property(e => e.MusicalGenre)
                .IsUnicode(false);

            modelBuilder.Entity<Band>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Band>()
                .Property(e => e.InTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);
        }
    }
}
