namespace Tuber.Core.Exceptions;
public class InvalidISO8601DateValueException : Exception
{
	public InvalidISO8601DateValueException(string badValue)
        : base($"Invalid ISO8601 Date Value: \"{badValue}\". Must be in the format YYYYMMDD.")
    {

	}
}
