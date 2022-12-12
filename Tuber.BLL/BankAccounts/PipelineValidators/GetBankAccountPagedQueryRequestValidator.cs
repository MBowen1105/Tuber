using FluentValidation;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;

namespace Tuber.BLL.BankAccounts.PipelineValidators;
public class GetBankAccountPagedQueryRequestValidator : AbstractValidator<BankAccountGetPagedQueryRequest>
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
