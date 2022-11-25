using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.Authorisation;
public  interface ICurrentUserService
{
    User AdminUser();
    User User();
}
