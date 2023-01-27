using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Services;
public  class InstitutionAccountRetrievalService : IInstitutionAccountRetrievalService
{
    private readonly IInstitutionAccountRepository _institutionAccountRepository;

    public InstitutionAccountRetrievalService(IInstitutionAccountRepository institutionAccountRepo)
    {
        _institutionAccountRepository = institutionAccountRepo;
    }

    public ServiceResult<InstitutionAccount> GetById(Guid institutionAccountId)
    {
        var institutionAccount = _institutionAccountRepository.GetById(institutionAccountId);

        if (institutionAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: institutionAccount,
                exception: new EntityDoesNotExistException(InstitutionAccount.FriendlyName, institutionAccount.InstitutionAccountId));

        return new ServiceResult<InstitutionAccount>(
            payload: institutionAccount);
    }

    public ServiceResult<List<InstitutionAccount>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<InstitutionAccount>>(
            payload: _institutionAccountRepository.GetPaged(pageNumber, pageSize));
    }

    public int CountPages(int pageSize)
    {
        return _institutionAccountRepository
            .CountPages(pageSize);
    }
}
