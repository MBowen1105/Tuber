using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;
using Tuber.Core.Exceptions;

namespace Tuber.Application.Subcategories.Commands.SubcategoryDelete
{
    public class SubcategoryDeleteCommandHandler : IRequestHandler<SubcategoryDeleteCommandRequest, SubcategoryDeleteCommandResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrievalService;
        private readonly ISubcategoryDeletionService _subcategoryDeletionService;

        public SubcategoryDeleteCommandHandler(
            ISubcategoryRetrievalService subcategoryRetrievalService,
            ISubcategoryDeletionService subcategoryDeletionService)
        {
            _subcategoryRetrievalService = subcategoryRetrievalService;
            _subcategoryDeletionService = subcategoryDeletionService;
        }

        public Task<SubcategoryDeleteCommandResponse> Handle(SubcategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _subcategoryRetrievalService.GetById(request.SubcategoryId);

            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Subcategory.FriendlyName, request.SubcategoryId)));

            if (serviceResultGetById.Payload.IsCoreSubcategory)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new CannotDeleteCoreEntityException(Subcategory.FriendlyName, request.SubcategoryId)));

            var serviceResultDelete = _subcategoryDeletionService.Delete(request.SubcategoryId);

            if (serviceResultDelete.HasFailed)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Subcategory.FriendlyName, request.SubcategoryId)));

            return Task.FromResult(new SubcategoryDeleteCommandResponse
            {
                DeletedCount = serviceResultDelete.Payload
            });
        }
    }
}
