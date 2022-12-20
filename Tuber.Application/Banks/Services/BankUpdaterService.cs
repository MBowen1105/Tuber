using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.Application.Banks.Services;
public class BankUpdaterService : IBankUpdaterService
{
    private readonly IBankRepository _bankRepo;

    public BankUpdaterService(IBankRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public ServiceResult<Bank> Add(string name, int orderBy)
    {
        var bank = new Bank
        {
            BankName = name,
            OrderBy = orderBy
        };

        bank = _bankRepo.Add(bank);

        if (bank.BankId == Guid.Empty)
            return new ServiceResult<Bank>(
                payload: bank,
                exception: new EntityAlreadyExistsException(Bank.FriendlyName, "Name", bank.BankName));

        _bankRepo.SaveChanges();

        return new ServiceResult<Bank>(payload: bank);
    }

    public ServiceResult<Bank> Update(Guid bankId, string name, int orderBy)
    {
        var bank = _bankRepo.Update(new Bank
        {
            BankId = bankId,
            BankName = name,
            OrderBy = orderBy
        });

        if (bank.BankId == Guid.Empty)
            return new ServiceResult<Bank>(
                payload: bank,
                exception: new EntityDoesNotExistException(Bank.FriendlyName, bank.BankId));

        _bankRepo.SaveChanges();

        return new ServiceResult<Bank>(payload: bank);
    }
}
