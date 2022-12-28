namespace Tuber.Application.Exceptions;
public class InvalidPageSizeException : Exception
{
    public InvalidPageSizeException(int badValue)
        : base($"Invalid Page Size: \"{badValue}\". Must be greater than 1.")
    {
    }
}
