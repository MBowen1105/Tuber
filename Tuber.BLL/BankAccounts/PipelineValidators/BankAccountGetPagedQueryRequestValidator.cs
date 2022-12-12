using FluentValidation;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;

namespace Tuber.BLL.BankAccounts.PipelineValidators;
public class BankAccountGetPagedQueryRequestValidator : AbstractValidator<BankAccountGetPagedQueryRequest>
{
    public BankAccountGetPagedQueryRequestValidator()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);


    }
}
