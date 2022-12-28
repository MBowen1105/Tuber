using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.Subcategories.Services;
public class SubcategoryDeletionService : ISubcategoryDeletionService
{
    private readonly ISubcategoryRepository _subcategoryRepo;

    public SubcategoryDeletionService(ISubcategoryRepository subcategoryRepo)
    {
        _subcategoryRepo = subcategoryRepo;
    }

    public ServiceResult<int> Delete(Guid subcategoryId)
    {
        var subcategoryModel = _subcategoryRepo.GetById(subcategoryId);

        if (subcategoryModel.SubcategoryId == Guid.Empty)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new EntityDoesNotExistException(Subcategory.FriendlyName, subcategoryId));

        if (subcategoryModel.IsCoreSubcategory)
            return new ServiceResult<int>(
                 payload: 0,
                 exception: new CannotDeleteCoreEntityException(Subcategory.FriendlyName, subcategoryId));

        var subcategory = _subcategoryRepo.Delete(subcategoryId);

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<int>(subcategory);
    }
}
