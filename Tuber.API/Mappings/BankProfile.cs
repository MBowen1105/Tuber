using AutoMapper;
using Tuber.BLL.Banks.Queries.GetBank;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.API.Mappings;

public class BankProfile : Profile
{
    public BankProfile()
    {
        CreateMap<GetBankAPIRequest, GetBankQueryRequest>();

        CreateMap<GetBankQueryResponse, GetBankAPIResponse>();
    }
}
