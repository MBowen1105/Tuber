namespace Tuber.Application.Exceptions;
public class InvalidPageNumberException : Exception
{
    public InvalidPageNumberException(int badValue)
        : base($"Invalid Page Number: \"{badValue}\". Must be greater than 1.")
    {
    }
}
