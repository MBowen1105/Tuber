using MediatR;
using Tuber.Core.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        private readonly ICategoryUpdaterService _CategoryUpdaterService;

        public DeleteCategoryCommandHandler(ICategoryUpdaterService CategoryUpdaterService)
        {
            _CategoryUpdaterService = CategoryUpdaterService;
        }

        public Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var result = _CategoryUpdaterService.Delete(request.CategoryId);

            return Task.FromResult(new DeleteCategoryCommandResponse
            {
                DeletedCount = result,
                Exceptions = (result == 0)
                    ? new List<Exception>
                        {
                                new EntityToDeleteDoesNotExistException("Categories", request.CategoryId)
                        }
                    : new List<Exception>()
            });
        }
    }
}
