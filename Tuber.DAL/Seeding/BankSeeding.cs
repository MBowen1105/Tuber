using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class BankSeeding
{
    private static Guid DEFAULT_USERID = Guid.Parse("02ceedc1-d3b4-4e5e-8844-0d853c24463b");

    public static void Seed(EntityTypeBuilder<Bank> builder)
    {
        builder.HasData(
            new Bank
            {
                Id = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Co-Op Bank",
                OrderBy = 10,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = DEFAULT_USERID,
                UpdatedOn = DateTime.UtcNow,
                UpdatedByUserId = DEFAULT_USERID,
                IsArchived = false,
            },
            new Bank
            {
                Id = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds Bank",
                OrderBy = 20,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = DEFAULT_USERID,
                UpdatedOn = DateTime.UtcNow,
                UpdatedByUserId = DEFAULT_USERID,
                IsArchived = false,
            },
            new Bank
            {
                Id = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                Name = "Barclays Bank",
                OrderBy = 30,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = DEFAULT_USERID,
                UpdatedOn = DateTime.UtcNow,
                UpdatedByUserId = DEFAULT_USERID,
                IsArchived = false,
            },
            new Bank
            {
                Id = Guid.Parse("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                Name = "Virgin Money",
                OrderBy = 40,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = DEFAULT_USERID,
                UpdatedOn = DateTime.UtcNow,
                UpdatedByUserId = DEFAULT_USERID,
                IsArchived = false,
            },
            new Bank
            {
                Id = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                Name = "TSB",
                OrderBy = 50,
                CreatedOn = DateTime.UtcNow,
                CreatedByUserId = DEFAULT_USERID,
                UpdatedOn = DateTime.UtcNow,
                UpdatedByUserId = DEFAULT_USERID,
                IsArchived = true,
            });
    }
}
