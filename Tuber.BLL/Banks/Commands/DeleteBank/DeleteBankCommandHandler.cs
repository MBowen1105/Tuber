using MediatR;
using Tuber.BLL.Banks.Commands.DeleteBank;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Banks.Commands.PutBank
{
    public class DeleteBankCommandHandler : IRequestHandler<DeleteBankCommandRequest, DeleteBankCommandResponse>
    {
        private readonly IBankService _bankService;

        public DeleteBankCommandHandler(IBankService bankService)
        {
            _bankService = bankService;
        }

        public Task<DeleteBankCommandResponse> Handle(DeleteBankCommandRequest request, CancellationToken cancellationToken)
        {
            var bankDto = _bankService.Delete(request.Id);

            var response = new DeleteBankCommandResponse();
            if (bankDto.Id == Guid.Empty)
                response.Exceptions.Add(new EntityToDeleteDoesNotExistException("Banks", request.Id));
            
            return Task.FromResult(response);
        }
    }
}
