using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Subcategories;

public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
{
    public void Configure(EntityTypeBuilder<Subcategory> builder)
    {
        builder.ToTable("Subcategories");

        builder.Property(x => x.SubcategoryId)
            .IsRequired();

        builder.Property(x => x.SubcategoryName)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.IsCoreSubcategory)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .IsRequired();

        SubcategorySeeding.Seed(builder);
    }
}
