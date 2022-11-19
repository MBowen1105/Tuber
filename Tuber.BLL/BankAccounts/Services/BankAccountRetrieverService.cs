using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Services;
internal class BankAccountRetrieverService : IBankAccountRetrieverService
{
    private readonly IBankAccountRepository _bankAccountRepository;

    public BankAccountRetrieverService(IBankAccountRepository bankAccountRepo)
    {
        _bankAccountRepository = bankAccountRepo;
    }

    public int CountPages(int pageSize)
    {
        return _bankAccountRepository
            .CountPages(pageSize);
    }

    public List<BankAccount> GetPaged(int pageNumber, int pageSize)
    {
        return _bankAccountRepository.GetPaged(pageNumber, pageSize);
    }
}
