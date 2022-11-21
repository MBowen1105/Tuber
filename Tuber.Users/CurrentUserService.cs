using Tuber.Domain.Interfaces.Infrastructure.Users;
using Tuber.Domain.Models;

namespace Tuber.Infrastructure.Users;
public class CurrentUserService : ICurrentUserService
{
    public Guid UserId() => Guid.Parse("6e5dc04b-3918-438e-bf9e-38aa5e880725");
    public User User() => new()
    {
        UserId = UserId(),
        FullName = "Mark Bowen",
        IsCoreUser = true,
        IsActive = true,
    };
}
