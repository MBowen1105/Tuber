using FluentValidation;
using Tuber.BLL.Banks.Commands;

namespace Tuber.BLL.Validators;
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
