using Microsoft.EntityFrameworkCore;
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
}
