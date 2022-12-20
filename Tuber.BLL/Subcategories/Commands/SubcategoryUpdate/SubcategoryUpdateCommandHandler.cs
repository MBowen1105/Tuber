using MediatR;
using Tuber.Domain.Interfaces.BLL;

namespace Tuber.BLL.Subcategories.Commands.SubcategoryUpdate
{
    public class SubcategoryUpdateCommandHandler : IRequestHandler<SubcategoryUpdateCommandRequest, SubcategoryUpdateCommandResponse>
    {
        private readonly ISubcategoryUpdaterService _subcategoryUpdaterService;

        public SubcategoryUpdateCommandHandler(ISubcategoryUpdaterService subcategoryUpdaterService)
        {
            _subcategoryUpdaterService = subcategoryUpdaterService;
        }

        public Task<SubcategoryUpdateCommandResponse> Handle(SubcategoryUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _subcategoryUpdaterService.Update(
                subcategoryId: request.SubcategoryId,
                subcategoryName: request.SubcategoryName);

            return Task.FromResult(new SubcategoryUpdateCommandResponse
            {
                SubcategoryId = serviceResult.Payload.SubcategoryId,
                SubcategoryName = serviceResult.Payload.SubcategoryName,
                Exceptions = serviceResult.Exceptions,
            });
        }
    }
}
