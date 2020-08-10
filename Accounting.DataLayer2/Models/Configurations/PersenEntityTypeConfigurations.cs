using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.DataLayer2.Models.Configurations
{
    class PersenEntityTypeConfigurations : IEntityTypeConfiguration<Persen>
    {
        public void Configure(EntityTypeBuilder<Persen> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("string")
                .HasColumnType("NVARCHAR(80)")
                .HasMaxLength(80);
            builder.Property(c=>c.Email)
                .IsRequired()
                .HasColumnType("email_address")
                .HasColumnType("varchar(200)");


            builder.Property(c => c.Password)
                .HasMaxLength(20)
                .IsRequired()
                ;
            builder.HasMany(g => g.DbGeographicalPoints)
                .WithOne(s => s.Persen)
                .HasForeignKey(s => s.ID);
        }
    }
}
