using FluentValidation;
using Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;

namespace Tuber.Application.BankAccounts.PipelineValidators;
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
