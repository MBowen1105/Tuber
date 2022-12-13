using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetById;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts;
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
