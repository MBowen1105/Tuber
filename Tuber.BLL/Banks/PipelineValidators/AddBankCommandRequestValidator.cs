using FluentValidation;
using Tuber.BLL.Banks.Commands.BankAdd;

namespace Tuber.BLL.Banks.PipelineValidators;

public class AddBankCommandRequestValidator : AbstractValidator<BankAddCommandRequest>
{
    public AddBankCommandRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(40);

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
