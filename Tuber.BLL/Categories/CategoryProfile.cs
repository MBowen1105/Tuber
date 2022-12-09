using AutoMapper;
using Tuber.BLL.Categories.Commands.AddCategory;
using Tuber.BLL.Categories.Queries.GetCategoriesPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categorys;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        //  API
        CreateMap<AddCategoryAPIRequest, AddCategoryCommandRequest>();
        CreateMap<AddCategoryCommandResponse, AddCategoryAPIResponse>();
        CreateMap<GetCategoriesPagedQueryResponse, GetCategoriesPagedAPIResponse>();

        CreateMap<Category, GetCategoriesPaged_Category>();
    }

}
