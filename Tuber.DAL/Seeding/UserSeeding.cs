using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuber.Domain.Models;

namespace Tuber.DAL.Seeding;
public static class UserSeeding
{
    public static readonly User ADMIN_USER = new()
    {
        UserId = Guid.Parse("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
        FullName = "Administrator",
        IsCoreUser = true
    };

    public static readonly User MARKBOWEN = new()
    {
        UserId = Guid.Parse("e13a3a77-93c1-4e64-8d58-a517ca1be8d1"),
        FullName = "Mark Bowen",
        IsCoreUser = true
    };

    public static void Seed(EntityTypeBuilder<User> builder)
    {
        builder.HasData(ADMIN_USER);
        builder.HasData(MARKBOWEN);
    }
}
