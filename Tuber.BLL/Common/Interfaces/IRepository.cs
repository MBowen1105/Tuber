namespace Tuber.Application.Common.Interfaces;
public interface IRepository<TEntity> where TEntity : class
{
    int SaveChanges();
}
