using MediatR;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.CategoryDelete
{
    public class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommandRequest, CategoryDeleteCommandResponse>
    {
        private readonly ICategoryUpdaterService _CategoryUpdaterService;

        public CategoryDeleteCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
        {
            _CategoryUpdaterService = CategoryUpdaterService;
        }

        public Task<CategoryDeleteCommandResponse> Handle(CategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _CategoryUpdaterService.Delete(request.CategoryId);

            return Task.FromResult(new CategoryDeleteCommandResponse
            {
                DeletedCount = serviceResult.Payload,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
