using AutoMapper;
using Tuber.BLL.Banks.Commands.PutBank;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks;
public class BankProfile : Profile
{
    public BankProfile()
    {
        //  API
        CreateMap<PutBankAPIRequest, PutBankCommandRequest>();
        CreateMap<PutBankCommandResponse, PutBankAPIResponse>();
        CreateMap<GetBankByIdQueryResponse, GetBankByIdAPIResponse>();
        CreateMap<GetBankPagedQueryResponse, GetBankPagedAPIResponse>();
        
        //  Services
        CreateMap<Bank, BankDto>().ReverseMap();
    }

}
