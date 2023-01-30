using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces.Authentication;
//TODO: Rename this IAuthentication
public interface IAuthenticationService
{
    User AdminUser();
    User User();
}
