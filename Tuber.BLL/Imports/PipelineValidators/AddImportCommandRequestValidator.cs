using FluentValidation;
using Tuber.BLL.Imports.Commands.AddImport;

namespace Tuber.BLL.Imports.PipelineValidators;

public class AddImportCommandRequestValidator : AbstractValidator<AddImportCommandRequest>
{
    public AddImportCommandRequestValidator()
    {
        RuleFor(x => x.ImportTemplateId)
            .NotEmpty();

        RuleFor(x => x.BankAccountId)
            .NotEmpty();

        RuleFor(x => x.ImportFileName)
            .NotEmpty();
    }
}
