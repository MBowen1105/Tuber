using FluentValidation;
using Tuber.BLL.Imports.Commands.ImportAdd;

namespace Tuber.BLL.Imports.PipelineValidators;

public class ImportAddAddCommandRequestValidator : AbstractValidator<ImportAddCommandRequest>
{
    public ImportAddAddCommandRequestValidator()
    {
        RuleFor(x => x.ImportTemplateId)
            .NotEmpty();

        RuleFor(x => x.BankAccountId)
            .NotEmpty();

        RuleFor(x => x.ImportFileName)
            .NotEmpty();
    }
}
