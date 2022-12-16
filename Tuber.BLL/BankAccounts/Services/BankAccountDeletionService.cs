using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Services;
public class BankAccountDeletionService : IBankAccountDeletionService
{
    private readonly IBankAccountRepository _bankAccountRepo;

    public BankAccountDeletionService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public ServiceResult<int> Delete(Guid bankAccountId)
    {
        var deletedCount = _bankAccountRepo.Delete(bankAccountId);

        if (deletedCount == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(BankAccount.FriendlyName, bankAccountId));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<int>(1);
    }
}
