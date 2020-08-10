﻿// <auto-generated />
using Accounting.DataLayer2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounting.DataLayer2.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.DataLayer2.Models.DbGeographicalPoints", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<double>("Gpoint")
                        .HasColumnType("float");

                    b.Property<double>("Lat1")
                        .HasColumnType("float");

                    b.Property<double>("Lat2")
                        .HasColumnType("float");

                    b.Property<double>("Lon1")
                        .HasColumnType("float");

                    b.Property<double>("Lon2")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("DbGeographicalPoints");
                });

            modelBuilder.Entity("Accounting.DataLayer2.Models.Persen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Persen");
                });

            modelBuilder.Entity("Accounting.DataLayer2.Models.DbGeographicalPoints", b =>
                {
                    b.HasOne("Accounting.DataLayer2.Models.Persen", "Persen")
                        .WithMany("DbGeographicalPoints")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}