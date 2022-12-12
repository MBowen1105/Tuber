namespace Tuber.Domain.Exceptions;
public class SubcategoryDoesNotExistException : Exception
{
    public SubcategoryDoesNotExistException(Guid subcategoryId)
        : base($"Subcategory Does Not Exist: \"{subcategoryId}\".")
    {
    }
}
