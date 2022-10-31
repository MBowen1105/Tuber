using FluentValidation;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.API.Validators;
public class GetBankAPIRequestValidator : AbstractValidator<GetBankAPIRequest>
{
	public GetBankAPIRequestValidator()
	{
        RuleFor(x => x.FromDate)
            .NotEmpty()
            .Length(8)
            .Matches(@"^\d{8}$");

        RuleFor(x => x.NumberOfDays)
            .NotEmpty()
            .InclusiveBetween(1, 10)
                .WithMessage("Number of days must be between 1 and 10 only");

        
    }
}
