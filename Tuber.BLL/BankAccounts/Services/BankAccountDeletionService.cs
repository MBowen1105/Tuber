using Tuber.Application.Common.Interfaces;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.BankAccounts.Services;
public class BankAccountDeletionService : IBankAccountDeletionService
{
    private readonly IBankAccountRepository _bankAccountRepo;

    public BankAccountDeletionService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public ServiceResult<int> Delete(Guid bankAccountId)
    {
        //  Returns 0 (Failed) or 1 (Successful)
        var deletedCount = _bankAccountRepo.Delete(bankAccountId);
     
        if (deletedCount == 0)
            return new ServiceResult<int>(0, new EntityDoesNotExistException(
                ExceptionDbOperation.Delete, BankAccount.FriendlyName, bankAccountId));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<int>(deletedCount);
    }
}
