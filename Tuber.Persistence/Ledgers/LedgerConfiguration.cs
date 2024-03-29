﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Ledgers;

public class LedgerConfiguration : IEntityTypeConfiguration<Ledger>
{
    public void Configure(EntityTypeBuilder<Ledger> builder)
    {
        builder.ToTable("Ledgers");

        builder.HasOne(x => x.CreatedByUser);

        builder.HasOne(x => x.UpdatedByUser);

        builder.Property(x => x.InstitutionAccountId)
            .IsRequired();

        builder.Property(x => x.DateUtc)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(40);

        builder.Property(x => x.Reference)
           .HasMaxLength(40);

        builder.Property(x => x.TransactionType)
          .HasMaxLength(15);

        builder.Property(x => x.Balance)
          .HasMaxLength(15);

        builder.Property(x => x.CategoryId)
           .IsRequired();

        builder.Property(x => x.SubcategoryId);

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOnUtc)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired();

        LedgerSeeding.Seed(builder);
    }
}
