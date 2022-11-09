namespace Tuber.Domain.Interfaces.DAL;
public interface IRepository<TEntity> where TEntity : class
{
    List<TEntity> GetAll();
    int SaveChanges();
}
