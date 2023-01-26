using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions.Services;
public class InstitutionDeletionService : IInstitutionDeletionService
{
    private readonly IInstitutionRepository _bankRepo;

    public InstitutionDeletionService(IInstitutionRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public ServiceResult<int> Delete(Guid bankId)
    {
        var bank = _bankRepo.Delete(bankId);

        if (bank == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(Institution.FriendlyName, bankId));

        _bankRepo.SaveChanges();

        return new ServiceResult<int>(bank);
    }
}
