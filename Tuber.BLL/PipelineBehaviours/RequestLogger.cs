using MediatR;

namespace Tuber.BLL.PipelineBehaviours;

public class RequestLogger<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>, IRequestlogger<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    //private readonly ILogger _logger;

    public RequestLogger()
    {
        // _logger = logger;
    }

    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        //_logger.LogInformation(request.ToString());

        return next();
    }
}

