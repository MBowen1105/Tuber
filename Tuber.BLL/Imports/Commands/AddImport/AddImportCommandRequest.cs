using MediatR;

namespace Tuber.BLL.Imports.Commands.AddImport;
public class AddImportCommandRequest : IRequest<AddImportCommandResponse>
{
    public Guid ImportTemplateId { get; init; }
    public Guid BankAccountId { get; init; }
    public string ImportFileName { get; set; } = "";
}
