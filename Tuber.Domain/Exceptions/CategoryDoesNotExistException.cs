namespace Tuber.Domain.Exceptions;
public class CategoryDoesNotExistException : Exception
{
    public CategoryDoesNotExistException(Guid badValue)
        : base($"Category Does Not Exist: \"{badValue}\".")
    {
    }
}
