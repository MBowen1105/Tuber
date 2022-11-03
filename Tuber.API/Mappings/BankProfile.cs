using AutoMapper;
using Tuber.BLL.Banks.Queries.GetBank;
using Tuber.Domain.Banks.GetBank;
using Tuber.Domain.Banks.Models;

namespace Tuber.API.Mappings;

public class BankProfile : Profile
{
    public BankProfile()
    {
        CreateMap<BankModel, BankDto>()
            .ReverseMap();

        CreateMap<GetBankAPIRequest, GetBankQueryRequest>();

        CreateMap<GetBankQueryResponse, GetBankAPIResponse>();
    }
}
