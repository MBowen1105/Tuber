using AutoMapper;
using Tuber.Application.Ledgers.Commands.LedgerAddCredit;
using Tuber.Application.Ledgers.Queries.LedgerGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Ledgers;
public class LedgerProfile : Profile
{
    public LedgerProfile()
    {
        //  LedgerGetPaged
        CreateMap<Ledger, LedgerGetPaged_Ledger>();
        CreateMap<LedgerGetPagedQueryResponse, LedgerGetPagedAPIResponse>();

        //  LedgerAddCredit
        CreateMap<LedgerAddCreditAPIRequest, LedgerAddCreditCommandRequest>();
        CreateMap<LedgerAddCreditCommandResponse, LedgerAddCreditAPIResponse>();
    }
}
