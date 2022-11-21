using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Users;

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

        builder.Property(x => x.IsActive)
                    .IsRequired()
                    .HasDefaultValue(true);

        UserSeeding.Seed(builder);
    }
}
