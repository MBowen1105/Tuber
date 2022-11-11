namespace Tuber.Core.Exceptions;
public class EntityToDeleteDoesNotExistException : Exception
{
    public EntityToDeleteDoesNotExistException(string collectionName, Guid badId)
        : base($"The Collection \"{collectionName}\" does not have an entry with the key \"{badId}\".")
    { }
}
