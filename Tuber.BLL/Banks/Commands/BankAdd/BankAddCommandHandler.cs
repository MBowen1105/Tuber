using MediatR;
using Tuber.BLL.Banks.Commands.AddBank;
using Tuber.BLL.Interfaces;

namespace Tuber.BLL.Banks.Commands.BankAdd;

public class BankAddCommandHandler : IRequestHandler<BankAddCommandRequest, BankAddCommandResponse>
{
    private readonly IBankUpdaterService _bankUpdaterService;

    public BankAddCommandHandler(IBankUpdaterService bankUpdaterService)
    {
        _bankUpdaterService = bankUpdaterService;
    }

    public Task<BankAddCommandResponse> Handle(BankAddCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _bankUpdaterService.Add(request.Name, request.OrderBy);

        return Task.FromResult(new BankAddCommandResponse
        {
            BankId = serviceResult.Payload.BankId,
            BankName = serviceResult.Payload.BankName!,
            OrderBy = serviceResult.Payload.OrderBy,
        });
    }
}
