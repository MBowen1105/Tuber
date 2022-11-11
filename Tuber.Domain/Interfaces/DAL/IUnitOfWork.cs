namespace Tuber.Domain.Interfaces.DAL;
public interface IUnitOfWork : IDisposable
{
    IBankRepository Banks { get; }
    IBankAccountRepository BankAccounts { get; }
    Task<int> Complete();
}
