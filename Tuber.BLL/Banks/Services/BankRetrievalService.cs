using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Services;
internal class BankRetrievalService : IBankRetrievalService
{
    private readonly IBankRepository _bankRepository;

    public BankRetrievalService(IBankRepository bankRepo)
    {
        _bankRepository = bankRepo;
    }

    public ServiceResult<Bank> GetById(Guid bankId)
    {
        var bank = _bankRepository.GetById(bankId);

        return new ServiceResult<Bank>(bank, new List<Exception>()
                {
                    new BankDoesNotExistException(bankId)
                });
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
