using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.Infrastructure.Users;
public  interface ICurrentUserService
{
    Guid UserId();
    User User();
}
