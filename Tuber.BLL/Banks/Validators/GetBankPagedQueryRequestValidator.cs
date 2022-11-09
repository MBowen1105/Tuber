using FluentValidation;
using Tuber.BLL.Banks.Queries.GetBankPaged;

namespace Tuber.BLL.Banks.Validators;
public class GetBankPagedQueryRequestValidator : AbstractValidator<GetBankPagedQueryRequest>
{
    public GetBankPagedQueryRequestValidator()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .GreaterThanOrEqualTo(1);
    }
}
