namespace Tuber.Core.Exceptions;
public class InvalidPositiveIntegerException : Exception
{
    public InvalidPositiveIntegerException(int badValue)
        : base($"Positive Integers must be greater than zero: \"{badValue}\"")
    {

    }
}
