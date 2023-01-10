using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Authentication;
//TODO: Rename this IAuthentication
public interface ICurrentUserService
{
    User AdminUser();
    User User();
}
