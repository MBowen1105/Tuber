using FluentValidation;
using Tuber.BLL.BankAccounts.Queries.GetBankAccount;

namespace Tuber.BLL.Validators;
public class GetBankAccountPagedQueryRequestValidator : AbstractValidator<GetBankAccountPagedQueryRequest>
{
	public GetBankAccountPagedQueryRequestValidator()
	{
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        
    }
}
