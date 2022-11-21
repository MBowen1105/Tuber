﻿using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Commands.AddBank;

public class AddBankCommandHandler : IRequestHandler<AddBankCommandRequest, AddBankCommandResponse>
{
    private readonly IBankUpdaterService _bankUpdaterService;

    public AddBankCommandHandler(IBankUpdaterService bankUpdaterService)
    {
        _bankUpdaterService = bankUpdaterService;
    }

    public Task<AddBankCommandResponse> Handle(AddBankCommandRequest request, CancellationToken cancellationToken)
    {
        var bankModel = _bankUpdaterService.Add(request.Name, request.OrderBy);

        return Task.FromResult(new AddBankCommandResponse
        {
            Id = bankModel.BankId,
            Name = bankModel.Name!,
            OrderBy = bankModel.OrderBy,
            CreatedByUserName = bankModel.CreatedByUser!.FullName,
            CreatedOnUtc = bankModel.CreatedOnUtc
        });
    }
}
