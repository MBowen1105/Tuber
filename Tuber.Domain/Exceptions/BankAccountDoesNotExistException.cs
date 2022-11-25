namespace Tuber.Domain.Exceptions;
public class BankAccountDoesNotExistException : Exception
{
    public BankAccountDoesNotExistException(Guid bankAccountId)
        : base($"Bank Account Does Not Exist: \"{bankAccountId}\".")
    {
    }
}
