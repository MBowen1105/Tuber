using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Persistence.Banks;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Categories;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.Property(x => x.CategoryId)
            .IsRequired();

        builder.Property(x => x.CategoryName)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.IsCoreCategory)
            .IsRequired();
        
        builder.Property(x => x.IsDeleted)
            .IsRequired();

        CategorySeeding.Seed(builder);
    }
}
