﻿using AutoMapper;
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

        CreateMap<ImportTemplate, GetBankById_ImportTemplate>();
        CreateMap<BankAccount, GetBankById_BankAccount>();
        CreateMap<Bank, GetBankByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        

        CreateMap<Bank, BankDto>();
    }

}
