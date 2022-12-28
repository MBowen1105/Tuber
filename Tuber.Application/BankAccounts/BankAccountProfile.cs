using AutoMapper;
using Tuber.Application.BankAccounts.Queries.BankAccountGetById;
using Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Application.Dtos;
using Tuber.Application.Models;

namespace Tuber.Application.BankAccounts;
public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        //  BankAccountGetById
        CreateMap<BankAccountGetByIdQueryResponse, BankAccountGetByIdAPIResponse>();
        CreateMap<BankAccount, BankAccountGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  BanksGetPaged
        CreateMap<BankAccountGetPagedQueryResponse, BankAccountGetPagedAPIResponse>();
        CreateMap<BankAccount, BankAccountGetPaged_BankAccount>();

        //  TODO: BankAccountAdd
        //  TODO: BankAccountUpdate
        //  TODO: BankAccountDelete
    }

}
