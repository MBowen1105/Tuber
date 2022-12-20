using AutoMapper;
using Tuber.Application.Banks.Commands.AddBank;
using Tuber.Application.Banks.Commands.BankAdd;
using Tuber.Application.Banks.Commands.BankUpdate;
using Tuber.Application.Banks.Queries.BankGetById;
using Tuber.Application.Banks.Queries.BankGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Banks;
public class BankProfile : Profile
{
    public BankProfile()
    {
        //  BankGetById
        CreateMap<BankGetByIdQueryResponse, BankGetByIdAPIResponse>();
        CreateMap<Bank, BankGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  BanksGetPaged
        CreateMap<BankGetPagedQueryResponse, BankGetPagedAPIResponse>();
        CreateMap<Bank, BankGetPaged_Bank>();

        //  BankAdd
        CreateMap<BankAddAPIRequest, BankAddCommandRequest>();
        CreateMap<BankAddCommandResponse, BankAddAPIResponse>();

        //  BankUpdate
        CreateMap<BankUpdateAPIRequest, BankUpdateCommandRequest>();
        CreateMap<BankUpdateCommandResponse, BankUpdateAPIResponse>();

        //  TODO: BankDelete

        //  WTF are these?
        CreateMap<ImportTemplate, BankGetById_ImportTemplate>();
        CreateMap<BankAccount, BankGetById_BankAccount>();
        CreateMap<BankAccount, BankGetPaged_BankAccount>();
    }

}
