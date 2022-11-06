using AutoMapper;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Mappings;
public class BankAccountProfile : Profile
{
	public BankAccountProfile()
	{
        CreateMap<BankAccount, BankAccountDto>();
            //.ForMember(x => x.BankName, opt => opt.MapFrom(src => src.Bank.Name)); ;
    }
    
}
