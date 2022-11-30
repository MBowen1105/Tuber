using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountById;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts;
public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        CreateMap<BankAccount, BankAccountDto>();

        CreateMap<GetBankAccountPagedQueryResponse, GetBankAccountPagedAPIResponse>();
        CreateMap<GetBankAccountByIdQueryResponse, GetBankAccountByIdAPIResponse>();

        CreateMap<BankAccount, GetBankAccountByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act=>act.Ignore());

        //            .ForMember(dest => dest.BankAccountId, src => src.MapFrom(x => x.Payload.BankAccountId))

    }

}
