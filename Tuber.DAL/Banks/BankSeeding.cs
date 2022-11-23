using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Users;
using Tuber.Domain.Models;

namespace Tuber.DAL.Banks;
public static class BankSeeding
{

    public static void Seed(EntityTypeBuilder<Bank> builder)
    {
        builder.HasData(
            new Bank
            {
                BankId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
                Name = "Co-Op Bank",
                OrderBy = 10,
                ImportTemplateId = Guid.Parse("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
                Name = "Lloyds Bank",
                OrderBy = 20,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
                Name = "Barclays Bank",
                OrderBy = 30,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            },
            new Bank
            {
                BankId = Guid.Parse("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
                Name = "Virgin",
                OrderBy = 40,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Bank
            {
                BankId = Guid.Parse("5a250fff-d109-429a-b59d-e7582c6272a0"),
                Name = "West Bromwich Building Society",
                OrderBy = 50,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId
            },
            new Bank
            {
                BankId = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff"),
                Name = "TSB",
                OrderBy = 50,
                ImportTemplateId = null,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
                IsDeleted = true,
            }); ;
    }
}
