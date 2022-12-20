using MediatR;
using Tuber.Core.Enums;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Models;
using Tuber.Application.Common.Interfaces;

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
            //  Check to see if the SubCategory to delete is a Core Subcategory
            var serviceResultGetById = _subcategoryRetrievalService.GetById(request.SubcategoryId);

            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new EntityDoesNotExistException(ExceptionDbOperation.Delete, Subcategory.FriendlyName, request.SubcategoryId)));

            if (serviceResultGetById.Payload.IsCoreSubcategory)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new CannotDeleteCoreEntityException(Subcategory.FriendlyName, request.SubcategoryId)));

            var serviceResultDelete = _subcategoryDeletionService.Delete(request.SubcategoryId);

            return Task.FromResult(new SubcategoryDeleteCommandResponse(
                serviceResultDelete.Payload, serviceResultDelete.Exceptions));
        }
    }
}
