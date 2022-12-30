using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;
using Tuber.Persistence.Users;

namespace Tuber.Persistence.Ledgers;
public static class LedgerSeeding
{

    public static void Seed(EntityTypeBuilder<Ledger> builder)
    {
        //builder.HasData(
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("b63263ae-efc7-4ccb-ae50-7c17c3b2c2d6"),
        //        LedgerName = "Co-Op Ledger",
        //        OrderBy = 10,
        //        ImportTemplateId = Guid.Parse("44ec6e81-2ebf-4ec7-84b2-f74a87431962"),
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
        //    },
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("627daf5d-2c35-4644-8bc8-83b7f74278a9"),
        //        LedgerName = "Lloyds Ledger",
        //        OrderBy = 20,
        //        ImportTemplateId = null,
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
        //    },
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("1bde22e1-aa11-4f6f-ad78-4fd91cea3d64"),
        //        LedgerName = "Barclays Ledger",
        //        OrderBy = 30,
        //        ImportTemplateId = null,
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
        //    },
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("71eb1f8c-e3f3-4053-ad82-dbc90f16b5bf"),
        //        LedgerName = "Virgin",
        //        OrderBy = 40,
        //        ImportTemplateId = null,
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId
        //    },
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("5a250fff-d109-429a-b59d-e7582c6272a0"),
        //        LedgerName = "West Bromwich Building Society",
        //        OrderBy = 50,
        //        ImportTemplateId = null,
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId
        //    },
        //    new Ledger
        //    {
        //        LedgerId = Guid.Parse("123fc61c-0267-479e-875d-9e1d65bbcaff"),
        //        LedgerName = "TSB",
        //        OrderBy = 50,
        //        ImportTemplateId = null,
        //        CreatedOnUtc = DateTime.UtcNow,
        //        CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
        //        IsDeleted = true,
        //    });
    }
}
