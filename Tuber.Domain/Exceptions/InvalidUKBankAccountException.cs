namespace Tuber.Application.Exceptions;
public class InvalidUKInstitutionAccountException : Exception
{
    public InvalidUKInstitutionAccountException(string badValue)
        : base($"Invalid UK Institution Accout \"{badValue}\"")
    {
    }
}
