using Microsoft.EntityFrameworkCore;
using Tuber.Domain.Interfaces.Repositories;

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

    public List<TEntity> GetAll()
    {
        return _context.Set<TEntity>()
            .ToList();
    }

    public int SaveChanges()
    {
       return _context.SaveChanges();
    }
}

