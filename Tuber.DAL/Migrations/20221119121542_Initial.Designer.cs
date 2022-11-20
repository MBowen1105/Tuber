﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tuber.DAL;

#nullable disable

namespace Tuber.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221119121542_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tuber.Domain.Models.Bank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("OrderBy")
                        .HasColumnType("int");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Banks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9845),
                            IsArchived = false,
                            Name = "Co-Op Bank",
                            OrderBy = 10
                        },
                        new
                        {
                            Id = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9852),
                            IsArchived = false,
                            Name = "Lloyds Bank",
                            OrderBy = 20
                        },
                        new
                        {
                            Id = new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9855),
                            IsArchived = false,
                            Name = "Barclays Bank",
                            OrderBy = 30
                        },
                        new
                        {
                            Id = new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9857),
                            IsArchived = false,
                            Name = "Virgin Money",
                            OrderBy = 40
                        },
                        new
                        {
                            Id = new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 991, DateTimeKind.Utc).AddTicks(9858),
                            IsArchived = true,
                            Name = "TSB",
                            OrderBy = 50
                        });
                });

            modelBuilder.Entity("Tuber.Domain.Models.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("OrderBy")
                        .HasColumnType("int");

                    b.Property<string>("UKBankAccount")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("BankAccounts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2383),
                            IsArchived = false,
                            Name = "Salary",
                            OrderBy = 10,
                            UKBankAccount = "09411905"
                        },
                        new
                        {
                            Id = new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2390),
                            IsArchived = false,
                            Name = "Cash",
                            OrderBy = 20,
                            UKBankAccount = "00985630"
                        },
                        new
                        {
                            Id = new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2393),
                            IsArchived = false,
                            Name = "Savings",
                            OrderBy = 30,
                            UKBankAccount = "09405515"
                        },
                        new
                        {
                            Id = new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                            BankId = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2397),
                            IsArchived = false,
                            Name = "Lloyds 93DIX",
                            OrderBy = 10,
                            UKBankAccount = "09405515"
                        },
                        new
                        {
                            Id = new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                            BankId = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOn = new DateTime(2022, 11, 19, 12, 15, 41, 992, DateTimeKind.Utc).AddTicks(2399),
                            IsArchived = false,
                            Name = "Lloyds 25PAR",
                            OrderBy = 20,
                            UKBankAccount = "09405515"
                        });
                });

            modelBuilder.Entity("Tuber.Domain.Models.BankAccount", b =>
                {
                    b.HasOne("Tuber.Domain.Models.Bank", "Bank")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("Tuber.Domain.Models.Bank", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}