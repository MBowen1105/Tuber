using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Imports.Commands.AddImport;

public class AddImportCommandHandler : IRequestHandler<AddImportCommandRequest, AddImportCommandResponse>
{
    private readonly IImportUpdaterService _importUpdaterService;

    public AddImportCommandHandler(IImportUpdaterService importUpdaterService)
    {
        _importUpdaterService = importUpdaterService;
    }

    public Task<AddImportCommandResponse> Handle(AddImportCommandRequest request, CancellationToken cancellationToken)
    {
        var importResult = _importUpdaterService.ImportFile(request.ImportTemplateId, request.BankAccountId, request.ImportFileName);

        return Task.FromResult(new AddImportCommandResponse
        {
            BankAccountId = request.BankAccountId,
            ImportFileName = request.ImportFileName,
            ValidImportRowCount = importResult.Payload!.ValidRowCount,
            InvalidImportRowCount = importResult.Payload!.InvalidRowCount,
            Exceptions = importResult.Exceptions.ToList()
        });
    }
}
