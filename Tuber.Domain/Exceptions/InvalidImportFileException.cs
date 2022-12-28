namespace Tuber.Application.Exceptions;
public class InvalidImportFileException : Exception
{
    public InvalidImportFileException(string importFileLocation, string failureMessage)
         : base($"File: \"{importFileLocation}\": {failureMessage}")
    {
    }
}
