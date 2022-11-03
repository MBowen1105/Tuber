using AutoMapper;
using Tuber.Domain;
using Tuber.Domain.Banks.Models;
using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.BLL.Banks.Services;
internal class BankService : IBankService
{
    private readonly IBankRepository _bankRepository;
    private readonly IMapper _mapper;

    public BankService(IBankRepository bankRepo, IMapper mapper)
    {
        _bankRepository = bankRepo;
        _mapper = mapper;
    }

    public int CountPages(int pageSize)
    {
        return _bankRepository
            .CountPages(pageSize);
    }

    public List<BankDto> GetPaged(int pageNumber, int pageSize)
    {
        List<BankModel> bankModelList = _bankRepository.GetPaged(pageNumber, pageSize);

        return _mapper.Map<List<BankModel>, List<BankDto>>(bankModelList);
    }
}
