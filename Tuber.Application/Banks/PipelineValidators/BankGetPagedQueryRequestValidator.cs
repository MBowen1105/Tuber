using FluentValidation;
using Tuber.Application.Banks.Queries.BankGetPaged;

namespace Tuber.Application.Banks.PipelineValidators;
public class BankGetPagedQueryRequestValidator : AbstractValidator<BankGetPagedQueryRequest>
{
    public BankGetPagedQueryRequestValidator()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
