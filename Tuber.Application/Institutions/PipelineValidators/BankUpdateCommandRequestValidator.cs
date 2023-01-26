using FluentValidation;
using Tuber.Application.Institutions.Commands.InstitutionUpdate;

namespace Tuber.Application.Institutions.PipelineValidators;
public class PutInstitutionCommandRequestValidator : AbstractValidator<InstitutionUpdateCommandRequest>
{
    public PutInstitutionCommandRequestValidator()
    {
        RuleFor(x => x.InstitutionName)
            .NotEmpty()
            .MaximumLength(40);

        RuleFor(x => x.OrderBy)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
