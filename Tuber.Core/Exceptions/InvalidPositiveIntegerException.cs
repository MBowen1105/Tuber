namespace Tuber.Core.Exceptions;
public class InvalidPositiveIntegerException : Exception
{
    public InvalidPositiveIntegerException(int badValue)
        : base($"Invalid PosInt ({badValue}). Must be greater than zero.")
    {

    }
}
