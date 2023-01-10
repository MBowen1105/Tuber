namespace Tuber.Application.Exceptions;
public class ImportHasUnassignedCategoriesException : Exception
{
    public ImportHasUnassignedCategoriesException(Guid bankAccountId)
        : base($"The Import for Bank {bankAccountId} has unassigned Categories and cannot be Accepted.")
    {
    }
}
