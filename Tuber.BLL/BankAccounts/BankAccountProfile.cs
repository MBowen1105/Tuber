﻿using AutoMapper;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.BankAccounts;
public class BankAccountProfile : Profile
{
    public BankAccountProfile()
    {
        CreateMap<BankAccount, BankAccountDto>();

        CreateMap<GetBankAccountPagedQueryResponse, GetBankAccountPagedAPIResponse>();
    }

}