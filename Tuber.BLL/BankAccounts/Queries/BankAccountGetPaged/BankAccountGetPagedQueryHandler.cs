﻿using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetPaged
{
    public class BankAccountGetPagedQueryHandler : IRequestHandler<BankAccountGetPagedQueryRequest, BankAccountGetPagedQueryResponse>
    {
        private readonly IBankAccountRetrievalService _bankAccountRetrieverService;
        private readonly IMapper _mapper;

        public BankAccountGetPagedQueryHandler(IBankAccountRetrievalService bankAccountRetrieverService,
            IMapper mapper)
        {
            _bankAccountRetrieverService = bankAccountRetrieverService;
            _mapper = mapper;
        }

        public Task<BankAccountGetPagedQueryResponse> Handle(BankAccountGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountRetrieverService.GetPaged(request.PageNumber, request.PageSize);

            var response = new BankAccountGetPagedQueryResponse
            {
                BankAccountCount = serviceResult.Payload.Count,
                TotalPages = _bankAccountRetrieverService.CountPages(request.PageSize),
                BankAccounts = _mapper.Map<List<BankAccount>, List<BankAccountGetPaged_BankAccount>>(serviceResult.Payload)
            };

            return Task.FromResult(response);
        }
    }
}
