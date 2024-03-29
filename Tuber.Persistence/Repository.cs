﻿using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;

namespace Tuber.Persistence;
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
       return  _context.SaveChanges();
    }
}

