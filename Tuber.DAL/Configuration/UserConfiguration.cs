using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.DAL.Seeding;
using Tuber.Domain.Models;

namespace Tuber.DAL.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.IsCoreUser)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(x => x.CreatedByUserId)
            .IsRequired();

        builder.Property(x => x.CreatedOn)
            .IsRequired();

        builder.Property(x => x.IsArchived)
                    .IsRequired()
                    .HasDefaultValue(false);

        UserSeeding.Seed(builder);
    }
}
