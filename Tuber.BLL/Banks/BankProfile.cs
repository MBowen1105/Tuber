using AutoMapper;
using Tuber.BLL.Banks.Commands.AddBank;
using Tuber.BLL.Banks.Commands.BankAdd;
using Tuber.BLL.Banks.Commands.BankUpdate;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.BLL.Banks.Queries.GetBankPaged;
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

        CreateMap<GetBankByIdQueryResponse, GetBankByIdAPIResponse>();

        CreateMap<GetBankPagedQueryResponse, GetBankPagedAPIResponse>();

        CreateMap<ImportTemplate, GetBankById_ImportTemplate>();

        //  GetBankById
        CreateMap<BankAccount, GetBankById_BankAccount>();
        CreateMap<Bank, GetBankByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        
        //  GetBankPaged
        CreateMap<Bank, GetBankPaged_Bank>();
        CreateMap<BankAccount, GetBankPaged_BankAccount>();
    }

}
