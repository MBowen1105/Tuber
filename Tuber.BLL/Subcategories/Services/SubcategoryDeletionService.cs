using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Services;
public class SubcategoryDeletionService : ISubcategoryDeletionService
{
    private readonly ISubcategoryRepository _subcategoryRepo;

    public SubcategoryDeletionService(ISubcategoryRepository subcategoryRepo)
    {
        _subcategoryRepo = subcategoryRepo;
    }

    public ServiceResult<int> Delete(Guid subcategoryId)
    {
        var subcategory = _subcategoryRepo.Delete(subcategoryId);

        if (subcategory == 0)
            return new ServiceResult<int>(
                payload: 0,
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Delete, Subcategory.FriendlyName, subcategoryId));

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<int>(0);
    }
}
