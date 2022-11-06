using FluentValidation;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.API.Validators;
public class GetBankAPIRequestValidator : AbstractValidator<GetBankAPIRequest>
{
	public GetBankAPIRequestValidator()
	{
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
        
    }
}
