namespace Tuber.Core.Exceptions;
public class InvalidPositiveIntegerException : Exception
{
    public InvalidPositiveIntegerException(int badValue)
        : base($"Positive Integer cannot be negative: \"{badValue}\"")
    {

    }
}
