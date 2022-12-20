using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface IBankAccountUpdaterService
{
    ServiceResult<BankAccount> Add(string bankAccountName, string ukBankAccount, 
        string ukSortCode, int orderBy, Guid bankId, Guid? importTemplateId);
    ServiceResult<BankAccount> Update(Guid bankAccountId, string bankAccountName, string ukBankAccount,
        string ukSortCode, int orderBy, Guid bankId, Guid? importTemplateId);
}
