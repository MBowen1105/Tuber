using FluentValidation.Results;
using Tuber.Application.API.Common;

namespace Tuber.Application.Extensions;
public static class ValidationFailureExtensions
{
    public static BadRequestResponse[] ToBadRequestResponse(
        this IEnumerable<ValidationFailure> validationFailures)
    {
        return validationFailures.Select(x=> 
            new BadRequestResponse(
                x.ErrorMessage,
                x.PropertyName,
                x.AttemptedValue,
                x.Severity)
            ).ToArray();
    }
}