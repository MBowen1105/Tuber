namespace Tuber.Domain.Exceptions;
public class CannotDeleteCoreEntityException : Exception
{
    public CannotDeleteCoreEntityException(string entityName, Guid key)
        : base($"Cannot delete {entityName} Core entity with a key of \"{key}\".")
    {
    }
}
