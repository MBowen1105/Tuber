using AutoMapper;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;
using Tuber.Domain.Interfaces.Repositories;
using Tuber.Domain.Interfaces.Services;

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
        List<Bank> bankModelList = _bankRepository.GetPaged(pageNumber, pageSize);

        return _mapper.Map<List<Bank>, List<BankDto>>(bankModelList);
    }
}
