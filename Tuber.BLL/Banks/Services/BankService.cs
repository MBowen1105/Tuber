using AutoMapper;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

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
    
    public BankDto GetById(Guid id)
    {
        var bankModel = _bankRepository.GetById(id);

        return _mapper.Map<Bank, BankDto>(bankModel);
    }

    public List<BankDto> GetPaged(int pageNumber, int pageSize)
    {
        List<Bank> bankModelList = _bankRepository.GetPaged(pageNumber, pageSize);

        return _mapper.Map<List<Bank>, List<BankDto>>(bankModelList);
    }

    public Guid Add(string name, int orderBy)
    {
        var bankModel = new Bank
        {
            Name = name,
            OrderBy = orderBy,
            IsArchived = false
        };

        var id = _bankRepository.Add(bankModel);
        _bankRepository.SaveChanges();

        return id;
    }
    
    public int CountPages(int pageSize)
    {
        return _bankRepository.CountPages(pageSize);
    }

}
