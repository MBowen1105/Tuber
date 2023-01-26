using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions.Services;
public class InstitutionUpdaterService : IInstitutionUpdaterService
{
    private readonly IInstitutionRepository _bankRepo;

    public InstitutionUpdaterService(IInstitutionRepository bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public ServiceResult<Institution> Add(string bankName, int orderBy)
    {
        if (_bankRepo.NameExists(bankName))
            return new ServiceResult<Institution>(
                payload: new Institution(),
                exception: new EntityAlreadyExistsException(Institution.FriendlyName, "Name", bankName));

        var bank = new Institution
        {
            InstitutionName = bankName,
            OrderBy = orderBy
        };

        bank = _bankRepo.Add(bank);

        if (bank.InstitutionId == Guid.Empty)
            return new ServiceResult<Institution>(
                payload: bank,
                exception: new EntityAlreadyExistsException(Institution.FriendlyName, "Name", bank.InstitutionName));

        _bankRepo.SaveChanges();

        return new ServiceResult<Institution>(payload: bank);
    }

    public ServiceResult<Institution> Update(Guid bankId, string name, int orderBy)
    {
        var bank = _bankRepo.Update(new Institution
        {
            InstitutionId = bankId,
            InstitutionName = name,
            OrderBy = orderBy
        });

        if (bank.InstitutionId == Guid.Empty)
            return new ServiceResult<Institution>(
                payload: bank,
                exception: new EntityDoesNotExistException(Institution.FriendlyName, bank.InstitutionId));

        _bankRepo.SaveChanges();

        return new ServiceResult<Institution>(payload: bank);
    }
}
