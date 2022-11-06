namespace Tuber.Domain.Repositories.Interfaces;
public interface IRepository<TEntity> where TEntity : class
{
    List<TEntity> GetAll();
}
