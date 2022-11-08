using AutoMapper;
using Tuber.BLL.Banks.Commands;
using Tuber.BLL.Banks.Queries;
using Tuber.Domain.Banks;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Mappings;
public class BankProfile : Profile
{
	public BankProfile()
	{
        CreateMap<Bank, BankDto>().ReverseMap();
        CreateMap<GetBankByIdQueryResponse, GetBankByIdAPIResponse>();
        CreateMap<PutBankAPIRequest, PutBankCommandRequest>();
        CreateMap<PutBankCommandResponse, PutBankAPIResponse>();
    }
    
}
