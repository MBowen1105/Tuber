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
    [Migration("20221121183040_Initial3")]
    partial class Initial3
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
                    b.Property<Guid>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("OrderBy")
                        .HasColumnType("int");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("BankId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Banks", (string)null);

                    b.HasData(
                        new
                        {
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(3444),
                            IsActive = false,
                            Name = "Co-Op Bank",
                            OrderBy = 10
                        },
                        new
                        {
                            BankId = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(3450),
                            IsActive = false,
                            Name = "Lloyds Bank",
                            OrderBy = 20
                        },
                        new
                        {
                            BankId = new Guid("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(3453),
                            IsActive = false,
                            Name = "Barclays Bank",
                            OrderBy = 30
                        },
                        new
                        {
                            BankId = new Guid("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(3454),
                            IsActive = false,
                            Name = "Virgin Money",
                            OrderBy = 40
                        },
                        new
                        {
                            BankId = new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(3456),
                            IsActive = false,
                            Name = "TSB",
                            OrderBy = 50
                        });
                });

            modelBuilder.Entity("Tuber.Domain.Models.BankAccount", b =>
                {
                    b.Property<Guid>("BankAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

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

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("BankAccountId");

                    b.HasIndex("BankId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("BankAccounts", (string)null);

                    b.HasData(
                        new
                        {
                            BankAccountId = new Guid("0c942b54-d561-499a-843b-e4387e7e6415"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4926),
                            IsActive = false,
                            Name = "Salary",
                            OrderBy = 10,
                            UKBankAccount = "09411905"
                        },
                        new
                        {
                            BankAccountId = new Guid("552d16a1-d98b-48e9-8580-13029843c116"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4929),
                            IsActive = false,
                            Name = "Cash",
                            OrderBy = 20,
                            UKBankAccount = "00985630"
                        },
                        new
                        {
                            BankAccountId = new Guid("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                            BankId = new Guid("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4931),
                            IsActive = false,
                            Name = "Savings",
                            OrderBy = 30,
                            UKBankAccount = "09405515"
                        },
                        new
                        {
                            BankAccountId = new Guid("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                            BankId = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4933),
                            IsActive = false,
                            Name = "Lloyds 93DIX",
                            OrderBy = 10,
                            UKBankAccount = "09405515"
                        },
                        new
                        {
                            BankAccountId = new Guid("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                            BankId = new Guid("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4936),
                            IsActive = false,
                            Name = "Lloyds 25PAR",
                            OrderBy = 20,
                            UKBankAccount = "09405515"
                        },
                        new
                        {
                            BankAccountId = new Guid("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                            BankId = new Guid("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                            CreatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            CreatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4938),
                            IsActive = false,
                            Name = "TSB Bank Account",
                            OrderBy = 10,
                            UKBankAccount = "98765555",
                            UpdatedByUserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            UpdatedOnUtc = new DateTime(2022, 11, 21, 18, 30, 40, 254, DateTimeKind.Utc).AddTicks(4939)
                        });
                });

            modelBuilder.Entity("Tuber.Domain.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsCoreUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
                            FullName = "Administrator",
                            IsActive = false,
                            IsCoreUser = true
                        });
                });

            modelBuilder.Entity("Tuber.Domain.Models.Bank", b =>
                {
                    b.HasOne("Tuber.Domain.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tuber.Domain.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("Tuber.Domain.Models.BankAccount", b =>
                {
                    b.HasOne("Tuber.Domain.Models.Bank", "Bank")
                        .WithMany("BankAccounts")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tuber.Domain.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tuber.Domain.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId");

                    b.Navigation("Bank");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("Tuber.Domain.Models.Bank", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
