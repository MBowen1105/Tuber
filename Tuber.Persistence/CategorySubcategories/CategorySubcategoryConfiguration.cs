using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;
using Tuber.Persistence.Banks;

namespace Tuber.Persistence.CategorySubcategories;

public class CategorySubcategoryConfiguration : IEntityTypeConfiguration<CategorySubcategory>
{
    public void Configure(EntityTypeBuilder<CategorySubcategory> builder)
    {
        builder.ToTable("CategorySubcategories");

        builder.Property(x => x.CategorySubcategoryId)
            .IsRequired();

        builder.Property(x => x.CategoryId)
            .IsRequired();

        builder.Property(x => x.IsCoreCategorySubcategory)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .IsRequired();

        CategorySubcategorySeeding.Seed(builder);
    }
}
