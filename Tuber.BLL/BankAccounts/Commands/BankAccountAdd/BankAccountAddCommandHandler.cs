using MediatR;
using Tuber.Application.BankAccounts.Commands.AddAccountBank;
using Tuber.Application.Banks.Commands.AddBank;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.BankAccounts.Commands.BankAccountAdd;

public class BankAccountAddCommandHandler : IRequestHandler<BankAccountAddCommandRequest, BankAccountAddCommandResponse>
{
    private readonly IBankAccountUpdaterService _bankAccountUpdaterService;

    public BankAccountAddCommandHandler(IBankAccountUpdaterService bankAccountUpdaterService)
    {
        _bankAccountUpdaterService = bankAccountUpdaterService;
    }

    public Task<BankAccountAddCommandResponse> Handle(BankAccountAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _bankAccountUpdaterService.Add(
            request.BankAccountName, request.UKBankAccount, request.UKSortCode,
            request.OrderBy, request.BankId, request.ImportTemplateId);

        return Task.FromResult(new BankAccountAddCommandResponse
        {
            BankAccountId = serviceResult.Payload.BankAccountId,
            BankAccountName = serviceResult.Payload.BankAccountName!,
            UKBankAccount = serviceResult.Payload.UKBankAccount,
            BankId = serviceResult.Payload.BankId,
            ImportTemplateId = serviceResult.Payload.ImportTemplateId,
            OrderBy = serviceResult.Payload.OrderBy,
        });
    }
}
