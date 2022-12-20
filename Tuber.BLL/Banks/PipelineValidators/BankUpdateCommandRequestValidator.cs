using FluentValidation;
using Tuber.Application.Banks.Commands.BankUpdate;

namespace Tuber.Application.Banks.PipelineValidators;
public class PutBankCommandRequestValidator : AbstractValidator<BankUpdateCommandRequest>
{
    public PutBankCommandRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(40);

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
