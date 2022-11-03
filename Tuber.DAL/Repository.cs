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
        //var bankNames = new[]
        //    {
        //        "Co-Operative", "Lloyds", "Santander", "Halifax", "WBBS", "Nat West", "Barclays", "RBS", "Anna"
        //    };

        //return Enumerable.Range(1, pageSize).Select(index =>
        //        new BankModel
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            Name = bankNames[Random.Shared.Next(bankNames.Length)]
        //        })
        //    .ToList();

        return _context.Set<TEntity>().ToList();
    }
}

