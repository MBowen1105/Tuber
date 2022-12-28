namespace Tuber.Application.Common.Interfaces.Persistence;
public interface IRepository<TEntity> where TEntity : class
{
    int SaveChanges();
}
