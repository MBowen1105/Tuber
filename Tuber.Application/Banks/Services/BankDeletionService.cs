using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Banks.Services;
public class BankDeletionService : IBankDeletionService
{
    private readonly IBankRepository _bankRepo;

    public BankDeletionService(IBankRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public ServiceResult<int> Delete(Guid bankId)
    {
        var bank = _bankRepo.Delete(bankId);

        if (bank == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(Bank.FriendlyName, bankId));

        _bankRepo.SaveChanges();

        return new ServiceResult<int>(bank);
    }
}
