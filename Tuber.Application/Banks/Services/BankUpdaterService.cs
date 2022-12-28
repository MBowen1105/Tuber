using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.Banks.Services;
public class BankUpdaterService : IBankUpdaterService
{
    private readonly IBankRepository _bankRepo;

    public BankUpdaterService(IBankRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public ServiceResult<Bank> Add(string bankName, int orderBy)
    {
        if (_bankRepo.Exists(bankName))
            return new ServiceResult<Bank>(
                payload: new Bank(),
                exception: new EntityAlreadyExistsException(Bank.FriendlyName, "Name", bankName));

        var bank = new Bank
        {
            BankName = bankName,
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
