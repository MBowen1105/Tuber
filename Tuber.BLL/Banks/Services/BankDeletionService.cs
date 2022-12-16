using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Services;
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

        return new ServiceResult<int>(0);
    }
}
