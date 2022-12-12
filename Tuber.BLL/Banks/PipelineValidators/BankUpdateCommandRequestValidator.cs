using FluentValidation;
using Tuber.BLL.Banks.Commands.BankUpdate;

namespace Tuber.BLL.Banks.PipelineValidators;
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
