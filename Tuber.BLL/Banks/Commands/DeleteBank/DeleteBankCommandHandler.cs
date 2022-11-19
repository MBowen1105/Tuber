using MediatR;
using Tuber.BLL.Banks.Commands.DeleteBank;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Commands.PutBank
{
    public class DeleteBankCommandHandler : IRequestHandler<DeleteBankCommandRequest, DeleteBankCommandResponse>
    {
        private readonly IBankUpdaterService _bankUpdaterService;

        public DeleteBankCommandHandler(IBankUpdaterService bankUpdaterService)
        {
            _bankUpdaterService = bankUpdaterService;
        }

        public Task<DeleteBankCommandResponse> Handle(DeleteBankCommandRequest request, CancellationToken cancellationToken)
        {
            var result = _bankUpdaterService.Delete(request.Id);

            return Task.FromResult(new DeleteBankCommandResponse
            {
                DeletedCount = result,
                Exceptions = (result == 0)
                    ? new List<Exception>
                        {
                                new EntityToDeleteDoesNotExistException("Banks", request.Id)
                        }
                    : new List<Exception>()
            });
        }
    }
}
