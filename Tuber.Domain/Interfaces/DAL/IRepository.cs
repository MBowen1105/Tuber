namespace Tuber.Domain.Interfaces.DAL;
public interface IRepository<TEntity> where TEntity : class
{
    int SaveChanges();
}
