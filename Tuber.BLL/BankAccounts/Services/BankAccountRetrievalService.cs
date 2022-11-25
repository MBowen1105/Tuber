using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Services;
internal class BankAccountRetrievalService : IBankAccountRetrievalService
{
    private readonly IBankAccountRepository _bankAccountRepository;

    public BankAccountRetrievalService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepository = bankAccountRepo;
    }

    public int CountPages(int pageSize)
    {
        return _bankAccountRepository
            .CountPages(pageSize);
    }

    public ServiceResult<BankAccount> GetById(Guid bankAccountId)
    {
        var bankAccount = _bankAccountRepository.GetById(bankAccountId);
        
        if (bankAccount.BankId == Guid.Empty)
            return new ServiceResult<BankAccount>(bankAccount, new BankAccountDoesNotExistException(bankAccountId));
        
        return new ServiceResult<BankAccount>(bankAccount);
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _bankAccountRepository.GetPaged(pageNumber, pageSize);
    }
}
