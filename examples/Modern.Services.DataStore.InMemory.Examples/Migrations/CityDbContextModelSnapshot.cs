﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modern.Services.DataStore.InMemory.Examples.DbContexts;

#nullable disable

namespace Modern.EfCore.Examples.Migrations
{
    [DbContext(typeof(CityDbContext))]
    partial class CityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Modern.EfCore.Examples.Entities.CityDbo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<double>("Area")
                        .HasColumnType("REAL")
                        .HasColumnName("area");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("country");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER")
                        .HasColumnName("population");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("cities", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
