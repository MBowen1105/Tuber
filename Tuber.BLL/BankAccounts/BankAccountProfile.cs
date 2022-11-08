using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.GetBankAccount;
using Tuber.Domain.API.BankAccounts.GetBank;
using Tuber.Domain.Banks.GetBank;
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
