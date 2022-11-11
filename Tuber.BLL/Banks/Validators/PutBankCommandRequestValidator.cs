using FluentValidation;
using Tuber.BLL.Banks.Commands.PutBank;

namespace Tuber.BLL.Banks.Validators;
public class PutBankCommandRequestValidator : AbstractValidator<PutBankCommandRequest>
{
    public PutBankCommandRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
