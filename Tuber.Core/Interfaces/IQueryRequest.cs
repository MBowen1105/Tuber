using Tuber.Core.Enums;

namespace Tuber.Core.Interfaces;
public interface IQueryRequest<T>
{
    Guid ConsolidationId { get; init; }
    TuberEnvironment Environment { get; set; }
    T? Payload { get; set; }
}
