using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces.Authentication;
public interface ICurrentUserService
{
    User AdminUser();
    User User();
}
