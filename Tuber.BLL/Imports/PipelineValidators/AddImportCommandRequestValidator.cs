using FluentValidation;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Imports.PipelineValidators;

public class AddImportCommandRequestValidator : AbstractValidator<AddImportCommandRequest>
{
    //  TODO: Inject ImportTemplateRetrieverService
    public AddImportCommandRequestValidator(IBankAccountRetrieverService bankAccountRetrieverService)
    {
        RuleFor(x => x.ImportTemplateId)
            .NotEmpty();

        RuleFor(x => x.BankAccountId)
            .NotEmpty();

        RuleFor(x => x.ImportFileName)
            .NotEmpty();
    }
}
