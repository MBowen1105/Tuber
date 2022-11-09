using FluentValidation;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;

namespace Tuber.BLL.BankAccounts.Validators;
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
