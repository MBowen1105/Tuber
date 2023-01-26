using FluentValidation;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;

namespace Tuber.Application.InstitutionAccounts.PipelineValidators;
public class InstitutionAccountGetPagedQueryRequestValidator : AbstractValidator<InstitutionAccountGetPagedQueryRequest>
{
    public InstitutionAccountGetPagedQueryRequestValidator()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);


    }
}
