using AutoMapper;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts.Services;
internal class BankAccountService : IBankAccountService
{
    private readonly IBankAccountRepository _bankAccountRepository;
    private readonly IMapper _mapper;

    public BankAccountService(IBankAccountRepository bankAccountRepo, IMapper mapper)
    {
        _bankAccountRepository = bankAccountRepo;
        _mapper = mapper;
    }

    public int CountPages(int pageSize)
    {
        return _bankAccountRepository
            .CountPages(pageSize);
    }

    public List<BankAccountDto> GetPaged(int pageNumber, int pageSize)
    {
        List<BankAccount> bankAccountModelList = _bankAccountRepository.GetPaged(pageNumber, pageSize);

        return _mapper.Map<List<BankAccount>, List<BankAccountDto>>(bankAccountModelList);
    }
}
