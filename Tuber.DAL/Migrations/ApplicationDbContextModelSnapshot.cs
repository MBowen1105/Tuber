﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tuber.DAL;

#nullable disable

namespace Tuber.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tuber.Domain.Banks.Models.BankModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bank", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            IsArchived = false,
                            Name = "Co-Op Bank",
                            OrderBy = 10
                        },
                        new
                        {
                            Id = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            IsArchived = false,
                            Name = "Lloyds Bank",
                            OrderBy = 20
                        },
                        new
                        {
                            Id = new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                            IsArchived = false,
                            Name = "Barclays Bank",
                            OrderBy = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
