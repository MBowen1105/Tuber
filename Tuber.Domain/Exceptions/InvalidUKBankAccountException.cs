namespace Tuber.Domain.Exceptions;
public class InvalidUKBankAccountException : Exception
{
    public InvalidUKBankAccountException(string badValue)
        : base($"Invalid UK Bank Accout \"{badValue}\"")
    {
    }
}
