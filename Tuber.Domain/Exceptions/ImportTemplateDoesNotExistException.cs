namespace Tuber.Domain.Exceptions;
public class ImportTemplateDoesNotExistException : Exception
{
    public ImportTemplateDoesNotExistException(Guid badValue)
        : base($"Import Template Does Not Exist: \"{badValue}\".")
    {
    }
}
