﻿using MediatR;
using Tuber.Application.Banks.Commands.AddBank;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Banks.Commands.BankAdd;

public class BankAddCommandHandler : IRequestHandler<BankAddCommandRequest, BankAddCommandResponse>
{
    private readonly IBankUpdaterService _bankUpdaterService;

    public BankAddCommandHandler(IBankUpdaterService bankUpdaterService)
    {
        _bankUpdaterService = bankUpdaterService;
    }

    public Task<BankAddCommandResponse> Handle(BankAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _bankUpdaterService.Add(request.BankName, request.OrderBy);

        return Task.FromResult(new BankAddCommandResponse
        {
            BankId = serviceResult.Payload.BankId,
            BankName = serviceResult.Payload.BankName!,
            OrderBy = serviceResult.Payload.OrderBy,
        });
    }
}