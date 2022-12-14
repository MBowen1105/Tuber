namespace Tuber.Domain.Exceptions;
public class EntityDoesNotExistException : Exception
{
    public EntityDoesNotExistException(string entityName, string columnName, string key)
        : base($"{entityName} with a \"{columnName}\" of \"{key}\" does not exist.")
    {
    }
    public EntityDoesNotExistException(string entityName, Guid key)
        : base($"{entityName} with an ID of \"{key}\" does not exist.")
    {
    }
}
