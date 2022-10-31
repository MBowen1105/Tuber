using FluentValidation;
using Tuber.BLL.Banks.Queries.GetBank;

namespace Tuber.BLL.Validators;
public class GetBankQueryRequestValidator : AbstractValidator<GetBankQueryRequest>
{
	public GetBankQueryRequestValidator()
	{
        RuleFor(x => x.FromDate.Value)
            .NotEmpty()
            .Length(8);

        RuleFor(x => x.NumberOfDays.Value)
            .NotEmpty()
            .InclusiveBetween(1, 10);

        
    }
}
