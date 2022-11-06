using AutoMapper;
using Tuber.Domain.Banks.Models;

namespace Tuber.BLL.Mappings;
internal class BankProfile : Profile
{
	public BankProfile()
	{
        CreateMap<BankModel, BankDto>().ReverseMap();
    }
    
}
