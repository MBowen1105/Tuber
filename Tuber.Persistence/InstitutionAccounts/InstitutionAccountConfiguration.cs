using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.InstitutionAccounts;
public class InstitutionAccountConfiguration : IEntityTypeConfiguration<InstitutionAccount>
{
    public void Configure(EntityTypeBuilder<InstitutionAccount> builder)
    {
        builder.ToTable("InstitutionAccounts");

        builder.HasOne(x => x.Institution)
            .WithMany(x => x.InstitutionAccounts);

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.InstitutionAccountName)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.UKSortCode)
            .IsRequired()
            .HasMaxLength(6);

        builder.Property(x => x.UKInstitutionAccount)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.OpeningBalance)
            .HasDefaultValue(0)
           .IsRequired();

        builder.Property(x => x.InstitutionId)
           .IsRequired();

        builder.Property(x => x.OrderBy)
            .IsRequired();

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        InstitutionAccountSeeding.Seed(builder);
    }
}
