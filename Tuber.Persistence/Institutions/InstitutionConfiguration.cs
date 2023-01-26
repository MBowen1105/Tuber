using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Institutions;

public class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    public void Configure(EntityTypeBuilder<Institution> modelBuilder)
    {
        modelBuilder.ToTable("Institutions");

        modelBuilder.HasMany(x => x.InstitutionAccounts);

        modelBuilder.HasOne(x => x.CreatedByUser);

        modelBuilder.HasOne(x => x.UpdatedByUser);

        modelBuilder.Property(x => x.InstitutionName)
            .IsRequired()
            .HasMaxLength(40);

        modelBuilder.Property(x => x.OrderBy)
            .IsRequired();

        modelBuilder.Property(x => x.CreatedByUserId)
            .IsRequired();

        modelBuilder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        modelBuilder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        InstitutionSeeding.Seed(modelBuilder);
    }
}
