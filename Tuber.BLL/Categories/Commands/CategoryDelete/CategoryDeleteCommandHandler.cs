using MediatR;
using Tuber.BLL.Interfaces;

namespace Tuber.BLL.Categories.Commands.CategoryDelete
{
    public class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommandRequest, CategoryDeleteCommandResponse>
    {
        private readonly ICategoryDeletionService _categoryDeletionService;

        public CategoryDeleteCommandHandler(ICategoryDeletionService categoryDeletionService)
        {
            _categoryDeletionService = categoryDeletionService;
        }

        public Task<CategoryDeleteCommandResponse> Handle(CategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categoryDeletionService.Delete(request.CategoryId);

            return Task.FromResult(new CategoryDeleteCommandResponse
            {
                DeletedCount = serviceResult.Payload,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
