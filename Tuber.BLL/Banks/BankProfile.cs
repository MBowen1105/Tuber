using AutoMapper;
using Tuber.BLL.Banks.Commands.AddBank;
using Tuber.BLL.Banks.Commands.BankAdd;
using Tuber.BLL.Banks.Commands.BankUpdate;
using Tuber.BLL.Banks.Queries.BankGetById;
using Tuber.BLL.Banks.Queries.BankGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks;
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
