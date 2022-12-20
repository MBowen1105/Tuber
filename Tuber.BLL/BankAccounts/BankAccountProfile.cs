using AutoMapper;
using Tuber.Application.BankAccounts.Commands.AddAccountBank;
using Tuber.Application.BankAccounts.Commands.BankAccountAdd;
using Tuber.Application.BankAccounts.Commands.BankAccountUpdate;
using Tuber.Application.BankAccounts.Queries.BankAccountGetById;
using Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.BankAccounts;
public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        //  BankAccountAdd
        CreateMap<BankAccountAddAPIRequest, BankAccountAddCommandRequest>();
        CreateMap<BankAccountAddCommandResponse, BankAccountAddAPIResponse>();

        //  TODO: BankAccountUpdate
        CreateMap<BankAccountUpdateAPIRequest, BankAccountUpdateCommandRequest>();
        CreateMap<BankAccountUpdateCommandResponse, BankAccountUpdateAPIResponse>();

        //  TODO: BankAccountDelete

        //  BankAccountGetById
        CreateMap<BankAccountGetByIdQueryResponse, BankAccountGetByIdAPIResponse>();
        CreateMap<BankAccount, BankAccountGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  BanksGetPaged
        CreateMap<BankAccountGetPagedQueryResponse, BankAccountGetPagedAPIResponse>();
        CreateMap<BankAccount, BankAccountGetPaged_BankAccount>();
    }

}
