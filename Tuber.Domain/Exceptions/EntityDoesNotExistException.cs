using Tuber.Core.Enums;

namespace Tuber.Domain.Exceptions;
public class EntityDoesNotExistException : Exception
{
    public EntityDoesNotExistException(ExceptionDbOperation operation, string entityName, Guid key)
        : base($"Unable to {operation.ToString()}: No {entityName} exists with an Key of \"{key}\".")
    {
    }
}
