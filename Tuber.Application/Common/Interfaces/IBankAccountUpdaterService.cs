using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IBankAccountUpdaterService
{
    ServiceResult<BankAccount> Add(string bankAccountName, int orderBy);
    ServiceResult<BankAccount> Update(Guid bankAccountId, string bankAccountName, int orderBy);
}
