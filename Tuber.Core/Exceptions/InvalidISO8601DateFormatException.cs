namespace Tuber.Core.Exceptions;
public class InvalidISO8601DateFormatException : Exception
{
	public InvalidISO8601DateFormatException(string badValue)
		: base($"Invalid ISO8601 Date: \"{badValue}\". Must be 8 digits.")
	{ }
}
