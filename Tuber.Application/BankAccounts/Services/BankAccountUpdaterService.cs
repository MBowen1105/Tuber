using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.BankAccounts.Services;
public class BankAccountUpdaterService : IBankAccountUpdaterService
{
    private readonly IBankAccountRepository _bankAccountRepo;

    public BankAccountUpdaterService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public ServiceResult<BankAccount> Add(string name, int orderBy)
    {
        var bankAccount = new BankAccount
        {
            BankAccountName = name,
            OrderBy = orderBy
        };

        bankAccount = _bankAccountRepo.Add(bankAccount);

        if (bankAccount.BankAccountId == Guid.Empty)
            return new ServiceResult<BankAccount>(
                payload: bankAccount,
                exception: new EntityAlreadyExistsException(BankAccount.FriendlyName, "Name", bankAccount.BankAccountName));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<BankAccount>(payload: bankAccount);
    }

    public ServiceResult<BankAccount> Update(Guid bankAccountId, string name, int orderBy)
    {
        var bankAccount = _bankAccountRepo.Update(new BankAccount
        {
            BankAccountId = bankAccountId,
            BankAccountName = name,
            OrderBy = orderBy
        });

        if (bankAccount.BankAccountId == Guid.Empty)
            return new ServiceResult<BankAccount>(
                payload: bankAccount,
                exception: new EntityDoesNotExistException(BankAccount.FriendlyName, bankAccount.BankAccountId));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<BankAccount>(payload: bankAccount);
    }
}
