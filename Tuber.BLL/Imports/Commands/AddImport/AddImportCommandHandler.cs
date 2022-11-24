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
        var importResult = _importUpdaterService.Import(request.ImportTemplateId, request.BankAccountId, request.ImportFileName);

        return Task.FromResult(new AddImportCommandResponse
        {
            ImportId = importResult.ImportId,
            BankAccountId = request.BankAccountId,
            ImportFileName = request.ImportFileName,
            ValidImportRowCount = importResult.ValidRowCount,
            InvalidImportRowCount = importResult.InvalidRowCount,
            Exceptions = importResult.Exceptions
        });
    }
}
