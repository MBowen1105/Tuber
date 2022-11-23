using MediatR;
using Microsoft.Extensions.Logging;
using Tuber.Domain.Interfaces.Infrastructure.Users;

namespace Tuber.BLL.PipelineBehaviours;

public class RequestLogger<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>, IRequestlogger<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger _logger;
    private readonly ICurrentUserService _currentUserService;

    public RequestLogger(ILogger<RequestLogger<TRequest, TResponse>> logger, ICurrentUserService currentUserService)
    {
        _logger = logger;
        _currentUserService = currentUserService;
    }

    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        _logger.LogInformation("User {currentUser} called Request '{request}'.",
            _currentUserService.User().FullName, request);

        return next();
    }
}

