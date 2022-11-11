using Tuber.Domain.Interfaces.Infrastructure.Users;

namespace Tuber.Infrastructure.Users;
public class CurrentUserService : ICurrentUserService
{
    public Guid UserId() => Guid.Parse("6e5dc04b-3918-438e-bf9e-38aa5e880725");
}
