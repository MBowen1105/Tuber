using FluentValidation;
using Tuber.BLL.Banks.Queries.GetBank;

namespace Tuber.BLL.Validators;
public class GetBankQueryRequestValidator : AbstractValidator<GetBankQueryRequest>
{
	public GetBankQueryRequestValidator()
	{
        RuleFor(x => x.PageNumber.Value)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize.Value)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        
    }
}
