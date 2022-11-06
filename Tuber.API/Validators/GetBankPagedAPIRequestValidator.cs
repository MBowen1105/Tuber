using FluentValidation;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.API.Validators;
public class GetBankPagedAPIRequestValidator : AbstractValidator<GetBankPagedAPIRequest>
{
	public GetBankPagedAPIRequestValidator()
	{
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
        
    }
}
