using Tuber.Domain.Interfaces.Repositories;

namespace Tuber.Domain.Interfaces;
public interface IUnitOfWork : IDisposable
{
    IBankRepository Banks { get; }
    int Complete();

}
