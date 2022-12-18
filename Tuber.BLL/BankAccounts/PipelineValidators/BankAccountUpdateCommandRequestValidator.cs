using FluentValidation;
using Tuber.BLL.BankAccounts.Commands.BankAccountUpdate;

namespace Tuber.BLL.BankAccounts.PipelineValidators;
public class BankAccountUpdateCommandRequestValidator
    : AbstractValidator<BankAccountUpdateCommandRequest>
{
    public BankAccountUpdateCommandRequestValidator()
    {

        RuleFor(x => x.BankAccountId)
            .NotEmpty().NotNull();

        RuleFor(x => x.BankAccountName)
            .NotEmpty()
            .MaximumLength(40)
            .MinimumLength(1);

        RuleFor(x => x.UKSortCode)
            .NotEmpty()
            .Length(6)
            .InclusiveBetween("000000","999999");

        RuleFor(x => x.UKBankAccount)
           .NotEmpty()
           .Length(8)
           .InclusiveBetween("00000000", "99999999");

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.BankId)
            .NotEmpty().NotNull();
    }
}
