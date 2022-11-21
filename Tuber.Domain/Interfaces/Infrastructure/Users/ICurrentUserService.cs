using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.Infrastructure.Users;
public  interface ICurrentUserService
{
    User AdminUser();
    User User();
}
