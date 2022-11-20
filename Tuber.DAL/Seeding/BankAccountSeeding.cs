using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class BankAccountSeeding
{
    public static void Seed(EntityTypeBuilder<BankAccount> builder)
    {
        builder.HasData(
            new BankAccount
            {
                Id = Guid.Parse("0c942b54-d561-499a-843b-e4387e7e6415"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Salary",
                UKBankAccount = "09411905",
                OrderBy = 10,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER_ID,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Cash",
                UKBankAccount = "00985630",
                OrderBy = 20,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER_ID,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Savings",
                UKBankAccount = "09405515",
                OrderBy = 30,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER_ID,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("72fcf015-7f1b-49ef-8ea3-25d1ed15b936"),
                BankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds 93DIX",
                UKBankAccount = "09405515",
                OrderBy = 10,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER_ID,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("c38c85bd-19db-4b90-a1fa-aeb74610b70b"),
                BankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds 25PAR",
                UKBankAccount = "09405515",
                OrderBy = 20,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER_ID,
                IsArchived = false,
            });
    }
}
