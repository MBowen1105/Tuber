using Tuber.Core.Enums;
using Tuber.Domain.Common;
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
        //  A subcategory with the same name cannot be added.
        if (_subcategoryRepo.Exists(subcategoryName))
            return new ServiceResult<Subcategory>(
                payload: new Subcategory(),
                exception: new EntityAlreadyExistsException(Subcategory.FriendlyName, "Name", subcategoryName));

        var subcategory = _subcategoryRepo.Add(
            new Subcategory
            {
                SubcategoryName = subcategoryName,
            });

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<Subcategory>(subcategory);
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
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Update, Subcategory.FriendlyName, subcategory.SubcategoryId));

        _subcategoryRepo.SaveChanges();

        return new ServiceResult<Subcategory>(subcategory);
    }
}
