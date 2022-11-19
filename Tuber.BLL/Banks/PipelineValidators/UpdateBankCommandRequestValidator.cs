using FluentValidation;
using Tuber.BLL.Banks.Commands.UpdateBank;

namespace Tuber.BLL.Banks.PipelineValidators;
public class PutBankCommandRequestValidator : AbstractValidator<UpdateBankCommandRequest>
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
