using MediatR;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Commands.UpdateBank
{
    public class UpdateBankCommandHandler : IRequestHandler<UpdateBankCommandRequest, UpdateBankCommandResponse>
    {
        private readonly IBankRepository _bankRepo;

        public UpdateBankCommandHandler(IBankRepository bankRepo)
        {
            _bankRepo = bankRepo;
        }

        public Task<UpdateBankCommandResponse> Handle(UpdateBankCommandRequest request, CancellationToken cancellationToken)
        {
            var bank = _bankRepo.Update(new Bank
            {
                BankId = request.Id,
                Name = request.Name,
                OrderBy = request.OrderBy
            });

            _bankRepo.SaveChanges();

            return Task.FromResult(new UpdateBankCommandResponse
            {
                Id = bank.BankId,
                Name = bank.Name!,
                OrderBy = bank.OrderBy,
                CreatedByUserName = bank.CreatedByUser!.FullName,
                CreatedOnUtc = bank.CreatedOnUtc,
                UpdatedByUserName = bank.UpdatedByUserName,
                UpdatedOnUtc = bank.UpdatedOnUtc

            });
        }
    }
}
