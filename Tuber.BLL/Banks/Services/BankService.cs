using Tuber.Domain;
using Tuber.Domain.API.Banks.Models;
using Tuber.Domain.DAL;

namespace Tuber.BLL.Banks.Services;
internal class BankService : IBankService
{
    private readonly IBankRepo _bankRepo;

    public BankService(IBankRepo bankRepo)
    {
        _bankRepo = bankRepo;
    }

    public int CountPages(int pageSize)
    {
        return _bankRepo.CountPages(pageSize);
    }

    public List<BankDto> GetPaged(int pageNumber, int pageSize)
    {
        return _bankRepo.GetPaged(pageNumber, pageSize);
    }
}
