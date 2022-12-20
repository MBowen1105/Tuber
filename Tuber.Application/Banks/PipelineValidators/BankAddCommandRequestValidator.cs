using FluentValidation;
using Tuber.Application.Banks.Commands.BankAdd;

namespace Tuber.Application.Banks.PipelineValidators;

public class BankAddCommandRequestValidator : AbstractValidator<BankAddCommandRequest>
{
    public BankAddCommandRequestValidator()
    {
        RuleFor(x => x.BankName)
            .NotEmpty()
            .MaximumLength(40);

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
