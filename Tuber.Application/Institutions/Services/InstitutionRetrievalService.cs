using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions.Services;
public class InstitutionRetrievalService : IInstitutionRetrievalService
{
    private readonly IInstitutionRepository _bankRepository;

    public InstitutionRetrievalService(IInstitutionRepository bankRepo)
    {
        _bankRepository = bankRepo;
    }

    public ServiceResult<Institution> GetById(Guid bankId)
    {
        var bank = _bankRepository.GetById(bankId);

        if (bank.InstitutionId == Guid.Empty)
            return new ServiceResult<Institution>(
                payload: bank,
                exception: new EntityDoesNotExistException(Institution.FriendlyName, bankId));

        return new ServiceResult<Institution>(bank);
    }

    public ServiceResult<List<Institution>> GetPaged(int pageNumber, int pageSize) => 
        new(payload: _bankRepository.GetPaged(pageNumber, pageSize));

    public int CountPages(int pageSize) => _bankRepository.CountPages(pageSize);
}
