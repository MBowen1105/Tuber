using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.GetBankAccount;
using Tuber.BLL.Banks.Queries.GetBank;
using Tuber.Domain.API.BankAccounts.GetBank;
using Tuber.Domain.API.Banks.GetBank;
using Tuber.Domain.Banks.GetBank;

namespace Tuber.API.Mappings;

public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {

        CreateMap<GetBankAccountPagedAPIRequest, GetBankAccountPagedQueryRequest>();

        CreateMap<GetBankAccountPagedQueryResponse, GetBankAccountPagedAPIResponse>();
    }
}
