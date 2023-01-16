using AutoMapper;
using Tuber.Application.Ledgers.Queries.LedgerGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers;
public class LedgerProfile : Profile
{
    public LedgerProfile()
    {
        //  LedgerGetPaged
        CreateMap<Ledger, LedgerGetPaged_Ledger>()
            .ForMember(dest => dest.BankAccountName, src => src.Ignore())
            .ForMember(dest => dest.CategoryName, src => src.Ignore())
            .ForMember(dest => dest.SubcategoryName, src => src.Ignore());
        CreateMap<LedgerGetPagedQueryResponse, LedgerGetPagedAPIResponse>();
    }
}
