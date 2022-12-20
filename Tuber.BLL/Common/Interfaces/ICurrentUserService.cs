using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public  interface ICurrentUserService
{
    User AdminUser();
    User User();
}
