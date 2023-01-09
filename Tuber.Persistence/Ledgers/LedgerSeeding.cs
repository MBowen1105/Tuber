using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;
using Tuber.Persistence.Users;

namespace Tuber.Persistence.Ledgers;
public static class LedgerSeeding
{
    public static void Seed(EntityTypeBuilder<Ledger> builder)
    {
        builder.HasData(
            new Ledger
            {
                LedgerId = Guid.Parse("b581cb5c-8510-48de-b292-bd02641ec08d"),
                BankAccountId = BankAccounts.BankAccountSeeding.CoOpSalaryAccountId,
                DateUtc = new DateTime(2022, 11, 30),
                Description = "CAMELOT LOTTERY",
                Reference = "A00143/3965",
                TransactionType = "DD",
                MoneyIn = null,
                MoneyOut = 10,
                Balance = 604.44,
                CategorySubcategoryId = CategorySubcategories.CategorySubcategorySeeding.EntertainmentGamblingId,
                IsDeleted = false,
                CreatedOnUtc = DateTime.UtcNow,
                CreatedByUserId = UserSeeding.ADMIN_USER.UserId,
            });
    }
}
