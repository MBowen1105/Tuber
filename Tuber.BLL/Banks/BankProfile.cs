using AutoMapper;
using Tuber.BLL.Banks.Commands.AddBank;
using Tuber.BLL.Banks.Commands.UpdateBank;
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
        CreateMap<AddBankAPIRequest, AddBankCommandRequest>();
        CreateMap<AddBankCommandResponse, AddBankAPIResponse>();

        CreateMap<UpdateBankAPIRequest, UpdateBankCommandRequest>();
        CreateMap<UpdateBankCommandResponse, UpdateBankAPIResponse>();

        CreateMap<GetBankByIdQueryResponse, GetBankByIdAPIResponse>();

        CreateMap<GetBankPagedQueryResponse, GetBankPagedAPIResponse>();

        //  Services
        //CreateMap<Bank, BankDto>();
    }

}
