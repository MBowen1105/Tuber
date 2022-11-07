using FluentValidation;
using MediatR;

namespace Tuber.BLL.PipelineBehaviours;
public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    //  Gets a list of all validators of this TRequest type.
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        var context = new FluentValidation.ValidationContext<TRequest>(request);

        var validationFailures = _validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .ToList();

        if (validationFailures.Any())
        {
            throw new ValidationException(validationFailures);
        }

        return next();
    }
}

