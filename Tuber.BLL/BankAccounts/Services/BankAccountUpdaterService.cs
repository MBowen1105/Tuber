using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccountAccounts.Services;
public class BankAccountUpdaterService : IBankAccountUpdaterService
{
    private readonly IBankAccountRepository _bankAccountRepo;

    public BankAccountUpdaterService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public ServiceResult<BankAccount> Add(string bankAccountName, string ukBankAccount,
        string ukSortCode, int orderBy, Guid bankId, Guid? importTemplateId)
    {
        var bankAccount = new BankAccount
        {
            BankAccountName = bankAccountName,
            UKBankAccount = ukBankAccount,
            UKSortCode = ukSortCode,
            OrderBy = orderBy,
            BankId = bankId,
            ImportTemplateId = importTemplateId,
        };

        bankAccount = _bankAccountRepo.Add(bankAccount);

        if (bankAccount.BankAccountId == Guid.Empty)
            return new ServiceResult<BankAccount>(
                payload: bankAccount,
                exception: new EntityAlreadyExistsException(
                    BankAccount.FriendlyName,
                    "Name",
                    bankAccount.BankAccountName));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<BankAccount>(bankAccount);
    }

    public ServiceResult<BankAccount> Update(Guid bankAccountId, string bankAccountName, string ukBankAccount,
        string ukSortCode, int orderBy, Guid bankId, Guid? importTemplateId)
    {
        var bankAccount = new BankAccount
        {
            BankAccountId = bankAccountId,
            BankAccountName = bankAccountName,
            UKBankAccount = ukBankAccount,
            UKSortCode = ukSortCode,
            OrderBy = orderBy,
            BankId = bankId,
            ImportTemplateId = importTemplateId,
        };

        bankAccount = _bankAccountRepo.Update(bankAccount);

        if (bankAccount.BankAccountId == Guid.Empty)
            return new ServiceResult<BankAccount>(
                payload: bankAccount,
                exception: new EntityDoesNotExistException(
                    BankAccount.FriendlyName, bankAccount.BankAccountId));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<BankAccount>(bankAccount);
    }
}
