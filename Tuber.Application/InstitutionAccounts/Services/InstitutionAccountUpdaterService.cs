using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Services;
public class InstitutionAccountUpdaterService : IInstitutionAccountUpdaterService
{
    private readonly IInstitutionAccountRepository _institutionAccountRepo;

    public InstitutionAccountUpdaterService(IInstitutionAccountRepository institutionAccountRepo)
    {
        _institutionAccountRepo = institutionAccountRepo;
    }

    public ServiceResult<InstitutionAccount> Add(string institutionAccountName, 
        string UKSortCode, string UKInstitutionAccount,
        int orderBy, Guid? importTemplateId, double openingBalance)
    {
        var institutionAccount = new InstitutionAccount
        {
            InstitutionAccountName = institutionAccountName,
            UKSortCode = UKSortCode,
            UKInstitutionAccount = UKInstitutionAccount,
            OrderBy = orderBy,
            ImportTemplateId = importTemplateId,
            OpeningBalance = openingBalance
        };

        institutionAccount = _institutionAccountRepo.Add(institutionAccount);

        if (institutionAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: institutionAccount,
                exception: new EntityAlreadyExistsException(InstitutionAccount.FriendlyName, "Name", institutionAccount.InstitutionAccountName));

        _institutionAccountRepo.SaveChanges();

        return new ServiceResult<InstitutionAccount>(institutionAccount);
    }

    public ServiceResult<InstitutionAccount> Update(Guid institutionAccountId,
        string institutionAccountName, string UKSortCode, string UKInstitutionAccount,
        int orderBy, Guid? importTemplateId, double openingBalance)
    {
        var institutionAccount = _institutionAccountRepo.Update(new InstitutionAccount
        {
            InstitutionAccountId = institutionAccountId,
            InstitutionAccountName = institutionAccountName,
            UKSortCode = UKSortCode,
            UKInstitutionAccount = UKInstitutionAccount,
            OrderBy = orderBy,
            ImportTemplateId = importTemplateId,
            OpeningBalance = openingBalance
        });

        if (institutionAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: institutionAccount,
                exception: new EntityDoesNotExistException(InstitutionAccount.FriendlyName, institutionAccount.InstitutionAccountId));

        _institutionAccountRepo.SaveChanges();

        return new ServiceResult<InstitutionAccount>(payload: institutionAccount);
    }
}
