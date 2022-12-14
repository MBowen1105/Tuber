﻿using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Services;
public class SubcategoryUpdaterService : ISubcategoryUpdaterService
{
    private readonly ISubcategoryRepository _subcategoryRepo;

    public SubcategoryUpdaterService(ISubcategoryRepository subcategoryRepo)
    {
        _subcategoryRepo = subcategoryRepo;
    }

    public ServiceResult<Subcategory> Add(string subcategoryName)
    {
        var subcategory = new Subcategory
        {
            SubcategoryName = subcategoryName,
        };

        subcategory = _subcategoryRepo.Add(subcategory);

        if (subcategory.SubcategoryId == Guid.Empty)
            return new ServiceResult<Subcategory>(
                payload: subcategory,
                exception: new EntityAlreadyExistsException(Subcategory.FriendlyName, "Name", subcategory.SubcategoryName));

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<Subcategory>(payload: subcategory);
    }

    public ServiceResult<int> Delete(Guid subcategoryId)
    {
        var subcategory = _subcategoryRepo.Delete(subcategoryId);

        if (subcategory == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(Subcategory.FriendlyName, subcategoryId));

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<int>(0);
    }

    public ServiceResult<Subcategory> Update(Guid subcategoryId, string SubcategoryName)
    {
        var subcategory = new Subcategory
        {
            SubcategoryId = subcategoryId,
            SubcategoryName = SubcategoryName,
        };

        subcategory = _subcategoryRepo.Update(subcategory);
        if (subcategory.SubcategoryId == Guid.Empty)
            return new ServiceResult<Subcategory>(
                payload: subcategory,
                exception: new EntityDoesNotExistException(Subcategory.FriendlyName, subcategory.SubcategoryId));

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<Subcategory>(subcategory);
    }
}
