using FluentValidation.Results;
using Tuber.Domain.API.Common;

namespace Tuber.API.Extensions;
public static class ValidationFailureExtensions
{
    public static IEnumerable<BadRequestResponse> ToBadRequestResponse(
        this IEnumerable<ValidationFailure> validationFailures)
    {
        return validationFailures.Select(x=> 
            new BadRequestResponse(
                x.ErrorMessage,
                x.PropertyName,
                x.AttemptedValue,
                x.Severity)
            );
    }
}