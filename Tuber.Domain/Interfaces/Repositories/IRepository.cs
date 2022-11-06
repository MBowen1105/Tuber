namespace Tuber.Domain.Interfaces.Repositories;
public interface IRepository<TEntity> where TEntity : class
{
    List<TEntity> GetAll();
}
