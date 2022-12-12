using MediatR;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Commands.BankUpdate
{
    public class BankUpdateCommandHandler : IRequestHandler<BankUpdateCommandRequest, BankUpdateCommandResponse>
    {
        private readonly IBankRepository _bankRepo;

        public BankUpdateCommandHandler(IBankRepository bankRepo)
        {
            _bankRepo = bankRepo;
        }

        public Task<BankUpdateCommandResponse> Handle(BankUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var bank = _bankRepo.Update(new Bank
            {
                BankId = request.Id,
                Name = request.Name,
                OrderBy = request.OrderBy
            });

            _bankRepo.SaveChanges();

            return Task.FromResult(new BankUpdateCommandResponse
            {
                Id = bank.BankId,
                Name = bank.Name!,
                OrderBy = bank.OrderBy,
                CreatedByUserName = bank.CreatedByUser!.FullName,
                CreatedOnUtc = bank.CreatedOnUtc,
                UpdatedByUserName = bank.UpdatedByUser!.FullName!,
                UpdatedOnUtc = bank.UpdatedOnUtc

            });
        }
    }
}
