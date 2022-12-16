using MediatR;
using Tuber.Core.Exceptions;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryDelete
{
    public class SubcategoryDeleteCommandHandler : IRequestHandler<SubcategoryDeleteCommandRequest, SubcategoryDeleteCommandResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrievalService;
        private readonly ISubcategoryUpdaterService _subcategoryUpdaterService;

        public SubcategoryDeleteCommandHandler(
            ISubcategoryRetrievalService subcategoryRetrievalService,
            ISubcategoryUpdaterService subcategoryUpdaterService)
        {
            _subcategoryRetrievalService = subcategoryRetrievalService;
            _subcategoryUpdaterService = subcategoryUpdaterService;
        }

        public Task<SubcategoryDeleteCommandResponse> Handle(SubcategoryDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _subcategoryRetrievalService.GetById(request.SubcategoryId);

            if (!serviceResultGetById.IsSuccess)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException("Subcategory", request.SubcategoryId)));

            if (serviceResultGetById.Payload.IsCoreSubcategory)
                return Task.FromResult(new SubcategoryDeleteCommandResponse(
                    new CannotDeleteCoreEntityException("Subcategory", request.SubcategoryId)));

            var serviceResultDelete = _subcategoryUpdaterService.Delete(request.SubcategoryId);

            return Task.FromResult(new SubcategoryDeleteCommandResponse
            {
                DeletedCount = serviceResultDelete.Payload,
                Exceptions = (serviceResultDelete.Payload == 0)
                    ? new List<Exception>
                        {
                                new EntityToDeleteDoesNotExistException("Subcategory", request.SubcategoryId)
                        }
                    : new List<Exception>()
            });
        }
    }
}
