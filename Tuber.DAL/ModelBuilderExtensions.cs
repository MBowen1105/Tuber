using Microsoft.EntityFrameworkCore;
using Tuber.Domain.BankAccounts.Models;
using Tuber.Domain.Banks.Models;

namespace Tuber.DAL;
public static class ModelBuilderExtensions
{
    public static void SeedBanks(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankModel>().HasData(
            new BankModel
            {
                Id = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Co-Op Bank",
                OrderBy = 10,
                IsArchived = false,
            },
            new BankModel
            {
                Id = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds Bank",
                OrderBy = 20,
                IsArchived = false,
            },
            new BankModel
            {
                Id = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                Name = "Barclays Bank",
                OrderBy = 30,
                IsArchived = false,
            });
    }

    public static void SeedBankAccounts(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankAccountModel>().HasData(
            new BankAccountModel
            {
                Id = Guid.Parse("0c942b54-d561-499a-843b-e4387e7e6415"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Salary",
                OrderBy = 10,
                IsArchived = false,
            },
            new BankAccountModel
            {
                Id = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Cash",
                OrderBy = 20,
                IsArchived = false,
            },
            new BankAccountModel
            {
                Id = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Savings",
                OrderBy = 30,
                IsArchived = false,
            });
    }
}
