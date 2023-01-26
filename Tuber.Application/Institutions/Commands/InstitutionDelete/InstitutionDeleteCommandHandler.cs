using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Models;
using Tuber.Core.Exceptions;

namespace Tuber.Application.Institutions.Commands.InstitutionDelete
{
    public class InstitutionDeleteCommandHandler : IRequestHandler<InstitutionDeleteCommandRequest, InstitutionDeleteCommandResponse>
    {
        private readonly IInstitutionRetrievalService _InstitutionRetrievalService;
        private readonly IInstitutionDeletionService _InstitutionDeletionService;

        public InstitutionDeleteCommandHandler(
            IInstitutionRetrievalService InstitutionRetrievalService,
            IInstitutionDeletionService InstitutionDeletionService
            )
        {
            _InstitutionDeletionService = InstitutionDeletionService;
            _InstitutionRetrievalService = InstitutionRetrievalService;
        }

        public Task<InstitutionDeleteCommandResponse> Handle(InstitutionDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResultGetById = _InstitutionRetrievalService.GetById(request.InstitutionId);
            if (serviceResultGetById.HasFailed)
                return Task.FromResult(new InstitutionDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Institution.FriendlyName, request.InstitutionId)));

            var serviceResultDelete = _InstitutionDeletionService.Delete(request.InstitutionId);

            if (serviceResultDelete.HasFailed)
                return Task.FromResult(new InstitutionDeleteCommandResponse(
                    new EntityToDeleteDoesNotExistException(Institution.FriendlyName, request.InstitutionId)));

            return Task.FromResult(new InstitutionDeleteCommandResponse
            {
                DeletedCount = serviceResultDelete.Payload
            });
        }
    }
}
