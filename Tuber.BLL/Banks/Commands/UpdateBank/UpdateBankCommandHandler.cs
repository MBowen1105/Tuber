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
                Id = request.Id,
                Name = request.Name,
                OrderBy = request.OrderBy
            });

            _bankRepo.SaveChanges();

            return Task.FromResult(new UpdateBankCommandResponse
            {
                Id = bank.Id,
                Name = bank.Name,
                OrderBy = bank.OrderBy,
                CreatedByUserId = bank.CreatedByUserId,
                CreatedOn = bank.CreatedOn,
                UpdatedByUserId=bank.UpdatedByUserId,
                UpdatedOn = bank.UpdatedOn

            });
        }
    }
}
