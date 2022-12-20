using Tuber.Application.Common.Interfaces;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
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
        var deletedCount = _bankRepo.Delete(bankId);

        if (deletedCount == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Delete, Bank.FriendlyName, bankId));

        _bankRepo.SaveChanges();

        return new ServiceResult<int>(deletedCount);
    }
}
