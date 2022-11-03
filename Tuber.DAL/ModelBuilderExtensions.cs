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
                IsArchived = false,
            });

        
    }
}
