using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Repositories.Interfaces;

namespace Tuber.DAL;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public List<TEntity> GetPaged(int pageNumber, int pageSize)
    {
        return _context.Set<TEntity>().ToList();
    }
}

