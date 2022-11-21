﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class BankAccountSeeding
{
    public static void Seed(EntityTypeBuilder<BankAccount> builder)
    {
        builder.HasData(
            new BankAccount
            {
                BankAccountId = Guid.Parse("0c942b54-d561-499a-843b-e4387e7e6415"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Salary",
                UKBankAccount = "09411905",
                OrderBy = 10,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Cash",
                UKBankAccount = "00985630",
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Savings",
                UKBankAccount = "09405515",
                OrderBy = 30,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Guid.Parse("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                BankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds 93DIX",
                UKBankAccount = "09405515",
                OrderBy = 10,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Guid.Parse("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                BankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds 25PAR",
                UKBankAccount = "09405515",
                OrderBy = 20,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new BankAccount
            {
                BankAccountId = Guid.Parse("8cd1c1cf-a8e6-4148-a78c-99cd34c02997"),
                BankId = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                Name = "TSB Bank Account",
                UKBankAccount = "98765555",
                OrderBy = 10,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedByUserName = UserSeeding.ADMIN_USER.FullName,
                UpdatedOnUtc = DateTime.UtcNow,
                IsActive = false,
            });
    }
}
