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
        //  API
        CreateMap<BankAddAPIRequest, BankAddCommandRequest>();
        CreateMap<BankAddCommandResponse, BankAddAPIResponse>();

        CreateMap<BankUpdateAPIRequest, BankUpdateCommandRequest>();
        CreateMap<BankUpdateCommandResponse, BankUpdateAPIResponse>();

        CreateMap<BankGetByIdQueryResponse, BankGetByIdAPIResponse>();

        CreateMap<BankGetPagedQueryResponse, BankGetPagedAPIResponse>();

        CreateMap<ImportTemplate, BankGetById_ImportTemplate>();

        //  GetBankById
        CreateMap<BankAccount, BankGetById_BankAccount>();
        CreateMap<Bank, BankGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        
        //  GetBankPaged
        CreateMap<Bank, BankGetPaged_Bank>();
        CreateMap<BankAccount, BankGetPaged_BankAccount>();
    }

}
