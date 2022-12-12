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

    public Subcategory Add(string subcategoryName)
    {
        var subcategoryModel = _subcategoryRepo.Add(new Subcategory
        {
            SubcategoryName = subcategoryName,
        });

        _subcategoryRepo.SaveChanges();

        subcategoryModel = _subcategoryRepo.GetById(subcategoryModel.SubcategoryId);

        return subcategoryModel;
    }

    public int Delete(Guid subcategoryId)
    {
        var subcategoryModel = _subcategoryRepo.GetById(subcategoryId);

        if (subcategoryModel.SubcategoryId == Guid.Empty)
            return 0;

        var result = _subcategoryRepo.Delete(subcategoryId);

        _subcategoryRepo.SaveChanges();

        return result;
    }

    public Subcategory Update(Guid subcategoryId, string SubcategoryName)
    {
        var subcategoryModel = _subcategoryRepo.Update(new Subcategory
        {
            SubcategoryId = subcategoryId,
            SubcategoryName = SubcategoryName,
        });

        _subcategoryRepo.SaveChanges();

        return subcategoryModel;
    }
}
