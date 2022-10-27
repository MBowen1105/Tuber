using FluentValidation;

namespace Tuber.Domain.API.Common;
public record BadRequestResponse(string ErrorMessage, string PropertyName, object AttemptedValue, Severity Severity);
