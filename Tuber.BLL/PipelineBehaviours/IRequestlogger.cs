using MediatR;

namespace Tuber.BLL.PipelineBehaviours;
public interface IRequestlogger<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next);
}