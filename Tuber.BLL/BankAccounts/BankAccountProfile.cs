using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts;
public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        CreateMap<BankAccount, BankAccountDto>();
        //.ForMember(x => x.BankName, opt => opt.MapFrom(src => src.Bank.Name)); ;

        CreateMap<GetBankAccountPagedAPIRequest, GetBankAccountPagedQueryRequest>();

        CreateMap<GetBankAccountPagedQueryResponse, GetBankAccountPagedAPIResponse>();
    }

}
