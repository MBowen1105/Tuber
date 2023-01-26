using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Services;
public  class InstitutionAccountRetrievalService : IInstitutionAccountRetrievalService
{
    private readonly IInstitutionAccountRepository _bankAccountRepository;

    public InstitutionAccountRetrievalService(IInstitutionAccountRepository bankAccountRepo)
    {
        _bankAccountRepository = bankAccountRepo;
    }

    public ServiceResult<InstitutionAccount> GetById(Guid bankAccountId)
    {
        var bankAccount = _bankAccountRepository.GetById(bankAccountId);

        if (bankAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: bankAccount,
                exception: new EntityDoesNotExistException(InstitutionAccount.FriendlyName, bankAccount.InstitutionAccountId));

        return new ServiceResult<InstitutionAccount>(
            payload: bankAccount);
    }

    public ServiceResult<List<InstitutionAccount>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<InstitutionAccount>>(
            payload: _bankAccountRepository.GetPaged(pageNumber, pageSize));
    }

    public int CountPages(int pageSize)
    {
        return _bankAccountRepository
            .CountPages(pageSize);
    }
}
