namespace Tuber.Application.Exceptions;
public class InstitutionAccountHasNoImportTemplateDefinedException : Exception
{
    public InstitutionAccountHasNoImportTemplateDefinedException(string bankAccountName)
        : base($"The Institution Account {bankAccountName} has no Import Template defined.")
    {
    }
}
