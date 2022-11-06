using AutoMapper;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Mappings;
internal class BankProfile : Profile
{
	public BankProfile()
	{
        CreateMap<Bank, BankDto>().ReverseMap();
    }
    
}
