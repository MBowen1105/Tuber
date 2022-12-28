namespace Tuber.Application.Exceptions;
public class EntityAlreadyExistsException : Exception
{
    public EntityAlreadyExistsException(string entityName, string columnName, string key)
        : base($"{entityName} with a \"{columnName}\" of \"{key}\" already exists.")
    {
    }
}
