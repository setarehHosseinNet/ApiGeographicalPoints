using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Accounting.DataLayer2.Models
{
    class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)

        {
        }
        public ContextDB()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (local); Initial Catalog = DBGeographical; Integrated Security = true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.PersenEntityTypeConfigurations());
            modelBuilder.ApplyConfiguration(new Configurations.DbGeographicalPointsConfigurations());
        }

        public DbSet<Persen> Persen { get; set; }
        public DbSet<DbGeographicalPoints> DbGeographicalPoints { get; set; }
    }
}
