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
                OrderBy = 10,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("552d16a1-d98b-48e9-8580-13029843c116"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Cash",
                OrderBy = 20,
                IsArchived = false,
            },
            new BankAccount
            {
                Id = Guid.Parse("d2b75a9d-94af-41e4-8777-71251a92d3bf"),
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Savings",
                OrderBy = 30,
                IsArchived = false,
            });
    }
}
