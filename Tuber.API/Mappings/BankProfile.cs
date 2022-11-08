using AutoMapper;
using Tuber.BLL.Banks.Queries;
using Tuber.Domain.Banks;

namespace Tuber.API.Mappings;

public class BankProfile : Profile
{
    public BankProfile()
    {
        CreateMap<GetBankPagedQueryResponse, GetBankPagedAPIResponse>();
    }
}
