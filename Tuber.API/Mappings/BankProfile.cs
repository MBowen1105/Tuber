using AutoMapper;
using Tuber.BLL.Banks.Queries.GetBank;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.API.Mappings;

public class BankProfile : Profile
{
    public BankProfile()
    {
   
        //  Has to go from a (string date) "YYYYMMDD" in the API request to an (ISO8601) FromDate in the
        //  Query Request. Also from an (int) NumberOfDays in the API request, to an (PositiveInt) NumberOfDays
        //  in the Query Request.
        CreateMap<GetBankAPIRequest, GetBankQueryRequest>()
             .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => PositiveInt.From(src.PageNumber)))
             .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => PositiveInt.From(src.PageSize)));

        CreateMap<GetBankQueryResponse, GetBankAPIResponse>()
             .ForMember(dest => dest.BankCount, opt => opt.MapFrom(src => PositiveInt.From((int)src.BankCount)));
    }
}
