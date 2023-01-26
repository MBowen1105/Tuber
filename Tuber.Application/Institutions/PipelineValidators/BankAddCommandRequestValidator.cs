using FluentValidation;
using Tuber.Application.Institutions.Commands.InstitutionAdd;

namespace Tuber.Application.Institutions.PipelineValidators;

public class InstitutionAddCommandRequestValidator : AbstractValidator<InstitutionAddCommandRequest>
{
    public InstitutionAddCommandRequestValidator()
    {
        RuleFor(x => x.InstitutionName)
            .NotEmpty()
            .MaximumLength(40);

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
