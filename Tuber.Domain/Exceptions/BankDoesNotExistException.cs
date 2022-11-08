namespace Tuber.Domain.Exceptions;
public class BankDoesNotExistException : Exception
{
    public BankDoesNotExistException(Guid badValue)
        : base($"Bank Does Not Exist: \"{badValue}\".")
    {
    }
}
