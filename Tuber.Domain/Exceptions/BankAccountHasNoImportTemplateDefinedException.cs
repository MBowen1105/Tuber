namespace Tuber.Application.Exceptions;
public class BankAccountHasNoImportTemplateDefinedException : Exception
{
    public BankAccountHasNoImportTemplateDefinedException(string bankAccountName)
        : base($"The Bank Account {bankAccountName} has no Import Template defined.")
    {
    }
}
