using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryDelete
{
    public class CategorySubcategoryDeleteCommandHandler : IRequestHandler<CategorySubcategoryDeleteCommandRequest, CategorySubcategoryDeleteCommandResponse>
    {
        private readonly ICategorySubcategoryDeletionService _categorySubcategoryDeletionService;

        public CategorySubcategoryDeleteCommandHandler(
            ICategorySubcategoryDeletionService categorySubcategoryDeletionService
            )
        {
            _categorySubcategoryDeletionService = categorySubcategoryDeletionService;
        }

        public Task<CategorySubcategoryDeleteCommandResponse> Handle(CategorySubcategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categorySubcategoryDeletionService.Delete(request.CategorySubcategoryId);
            
            return Task.FromResult(
            new CategorySubcategoryDeleteCommandResponse(serviceResult.Payload, serviceResult.Exceptions));

        }
    }
}
