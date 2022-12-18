using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.BankAccounts.Commands.BankAccountUpdate
{
    public class BankAccountUpdateCommandHandler : IRequestHandler<BankAccountUpdateCommandRequest, BankAccountUpdateCommandResponse>
    {
        private readonly IBankAccountUpdaterService _bankAccountUpdaterService;

        public BankAccountUpdateCommandHandler(IBankAccountUpdaterService bankAccountUpdaterService)
        {
            _bankAccountUpdaterService = bankAccountUpdaterService;
        }

        public Task<BankAccountUpdateCommandResponse> Handle(BankAccountUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _bankAccountUpdaterService.Update(
                bankAccountId: request.BankAccountId,
                bankAccountName: request.BankAccountName,
                ukBankAccount: request.UKBankAccount,
                ukSortCode: request.UKSortCode,
                orderBy: request.OrderBy,
                bankId: request.BankId,
                importTemplateId: request.ImportTemplateId);

            return Task.FromResult(new BankAccountUpdateCommandResponse
            {
                BankAccountId = serviceResult.Payload.BankAccountId,
                BankAccountName = serviceResult.Payload.BankAccountName,
                UKBankAccount = request.UKBankAccount,
                UKSortCode = request.UKSortCode,
                OrderBy = serviceResult.Payload.OrderBy,
                BankId = serviceResult.Payload.BankId,
                ImportTemplateId = serviceResult.Payload.ImportTemplateId,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
