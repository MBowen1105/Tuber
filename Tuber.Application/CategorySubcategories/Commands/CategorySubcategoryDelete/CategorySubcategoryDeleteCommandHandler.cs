using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;
using Tuber.Core.Exceptions;

namespace Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryDelete
{
    public class CategorySubcategoryDeleteCommandHandler : IRequestHandler<CategorySubcategoryDeleteCommandRequest, CategorySubcategoryDeleteCommandResponse>
    {
        private readonly ICategorySubcategoryRetrievalService _categorySubcategoryRetrievalService;
        private readonly ICategorySubcategoryDeletionService _categorySubcategoryDeletionService;

        public CategorySubcategoryDeleteCommandHandler(
            ICategorySubcategoryRetrievalService categorySubcategoryRetrievalService,
            ICategorySubcategoryDeletionService categorySubcategoryDeletionService
            )
        {
            _categorySubcategoryDeletionService = categorySubcategoryDeletionService;
            _categorySubcategoryRetrievalService = categorySubcategoryRetrievalService;
        }

        public Task<CategorySubcategoryDeleteCommandResponse> Handle(CategorySubcategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _categorySubcategoryRetrievalService.GetById(request.CategorySubcategoryId);
            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new CategorySubcategoryDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(CategorySubcategory.FriendlyName, request.CategorySubcategoryId)));

            if (serviceResultGetById.Payload.IsCoreCategorySubcategory)
                return Task.FromResult(new CategorySubcategoryDeleteCommandResponse(
                    new CannotDeleteCoreEntityException(CategorySubcategory.FriendlyName, request.CategorySubcategoryId)));

            var serviceResultDelete = _categorySubcategoryDeletionService.Delete(request.CategorySubcategoryId);

            if (serviceResultDelete.HasFailed)
                return Task.FromResult(new CategorySubcategoryDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(CategorySubcategory.FriendlyName, request.CategorySubcategoryId)));

            return Task.FromResult(new CategorySubcategoryDeleteCommandResponse
            {
                DeletedCount = serviceResultDelete.Payload
            });
        }
    }
}
