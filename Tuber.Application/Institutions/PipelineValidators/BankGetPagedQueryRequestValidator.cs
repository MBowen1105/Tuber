using FluentValidation;
using Tuber.Application.Institutions.Queries.InstitutionGetPaged;

namespace Tuber.Application.Institutions.PipelineValidators;
public class InstitutionGetPagedQueryRequestValidator : AbstractValidator<InstitutionGetPagedQueryRequest>
{
    public InstitutionGetPagedQueryRequestValidator()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
