using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts.Services;
public class InstitutionAccountUpdaterService : IInstitutionAccountUpdaterService
{
    private readonly IInstitutionAccountRepository _bankAccountRepo;

    public InstitutionAccountUpdaterService(IInstitutionAccountRepository bankAccountRepo)
    {
        _bankAccountRepo = bankAccountRepo;
    }

    public ServiceResult<InstitutionAccount> Add(string name, int orderBy)
    {
        var bankAccount = new InstitutionAccount
        {
            InstitutionAccountName = name,
            OrderBy = orderBy
        };

        bankAccount = _bankAccountRepo.Add(bankAccount);

        if (bankAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: bankAccount,
                exception: new EntityAlreadyExistsException(InstitutionAccount.FriendlyName, "Name", bankAccount.InstitutionAccountName));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<InstitutionAccount>(payload: bankAccount);
    }

    public ServiceResult<InstitutionAccount> Update(Guid bankAccountId, string name, int orderBy)
    {
        var bankAccount = _bankAccountRepo.Update(new InstitutionAccount
        {
            InstitutionAccountId = bankAccountId,
            InstitutionAccountName = name,
            OrderBy = orderBy
        });

        if (bankAccount.InstitutionAccountId == Guid.Empty)
            return new ServiceResult<InstitutionAccount>(
                payload: bankAccount,
                exception: new EntityDoesNotExistException(InstitutionAccount.FriendlyName, bankAccount.InstitutionAccountId));

        _bankAccountRepo.SaveChanges();

        return new ServiceResult<InstitutionAccount>(payload: bankAccount);
    }
}
