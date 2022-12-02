using Tuber.Domain.Interfaces.Authorisation;
using Tuber.Domain.Models;

namespace Tuber.Authentication;

public class CurrentUserService : ICurrentUserService
{
    public User AdminUser() => new()
    {
        UserId = Guid.Parse("02ceedc1-d3b4-4e5e-8844-0d853c24463b"),
        FullName = "Administrator",
        IsCoreUser = true,
        IsDeleted = false,
    };

    public User User() => new()
    {
        UserId = Guid.Parse("e13a3a77-93c1-4e64-8d58-a517ca1be8d1"),
        FullName = "Mark Bowen",
        IsCoreUser = true,
        IsDeleted = false,
    };
}
