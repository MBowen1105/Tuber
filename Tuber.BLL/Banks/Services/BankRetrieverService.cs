using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Services;
internal class BankRetrieverService : IBankRetrieverService
{
    private readonly IBankRepository _bankRepository;

    public BankRetrieverService(IBankRepository bankRepo)
    {
        _bankRepository = bankRepo;
    }

    public Bank GetById(Guid id)
    {
        return _bankRepository.GetById(id);
    }

    public List<Bank> GetPaged(int pageNumber, int pageSize)
    {
        return _bankRepository.GetPaged(pageNumber, pageSize);
    }

    public int CountPages(int pageSize)
    {
        return _bankRepository.CountPages(pageSize);
    }
}
