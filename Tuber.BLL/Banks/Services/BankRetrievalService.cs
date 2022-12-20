using Tuber.Application.Common.Interfaces;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Banks.Services;
public class BankRetrievalService : IBankRetrievalService
{
    private readonly IBankRepository _bankRepository;

    public BankRetrievalService(IBankRepository bankRepo)
    {
        _bankRepository = bankRepo;
    }

    public ServiceResult<Bank> GetById(Guid bankId)
    {
        var bank = _bankRepository.GetById(bankId);

        if (bank.BankId == Guid.Empty)
            return new ServiceResult<Bank>(
                payload: bank,
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Get, Bank.FriendlyName, bankId));

        return new ServiceResult<Bank>(bank);
    }

    public ServiceResult<List<Bank>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<Bank>>(
            payload: _bankRepository.GetPaged(pageNumber, pageSize));
    }

    public int CountPages(int pageSize)
    {
        return _bankRepository.CountPages(pageSize);
    }
}
