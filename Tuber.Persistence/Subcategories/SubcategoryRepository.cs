﻿using Microsoft.EntityFrameworkCore;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Domain.Models;

namespace Tuber.Persistence.Subcategories;
public class SubcategoryRepository : ISubcategoryRepository
{
    private readonly ApplicationDbContext _context;

    public SubcategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    #region "Commands"
    public Subcategory Add(Subcategory subcategory)
    {
        try
        {
            _context.Subcategories.Add(subcategory);
        }
        catch (Exception)
        {
            subcategory = new Subcategory();
        }
        return subcategory;
    }

    public Subcategory Update(Subcategory subcategory)
    {
        var subcategoryModel = _context.Subcategories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.SubcategoryId == subcategory.SubcategoryId && x.IsDeleted == false);

        if (subcategoryModel is null)
            return new Subcategory();

        subcategoryModel.SubcategoryName = subcategory.SubcategoryName;

        return subcategoryModel;
    }

    public int Delete(Guid subcategoryId)
    {
        var subcategory = _context.Subcategories
            .FirstOrDefault(x => x.SubcategoryId == subcategoryId && x.IsDeleted == false);

        if (subcategory == null)
            return 0;

        subcategory.IsDeleted = true;

        return 1;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    #endregion

    #region "Queries"
    public Subcategory GetById(Guid subcategoryId)
    {
        var subcategory = _context.Subcategories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .FirstOrDefault(x => x.SubcategoryId == subcategoryId && x.IsDeleted == false);

        return subcategory ?? new Subcategory();
    }

    public List<Subcategory> GetPaged(int pageNumber, int pageSize)
    {
        var l = _context.Subcategories
            .Include(x => x.CreatedByUser)
            .Include(x => x.UpdatedByUser)
            .Where(x => x.IsDeleted == false)
            .Skip(pageNumber * pageSize - pageSize)
            .Take(pageSize)
            .ToList();
        return l;
    }

    public int CountPages(int pageSize)
    {
        var itemCount = _context.Subcategories
            .Count(x => x.IsDeleted == false);

        var totalPages = itemCount / (pageSize * 1.0);

        return (int)Math.Ceiling(totalPages);
    }

    #endregion
}
