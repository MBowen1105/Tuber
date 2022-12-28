using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Authorisation;
public interface ICurrentUserService
{
    User AdminUser();
    User User();
}
