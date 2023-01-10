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
            .ForMember(dest => dest.BankAccountBankAccountName, act => act.Ignore())
            .ForMember(dest => dest.CategorySubcategoryShortName, act => act.Ignore());
        CreateMap<LedgerGetPagedQueryResponse, LedgerGetPagedAPIResponse>();
    }
}
