using AutoMapper;
using MediatR;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Queries.GetSubcategoryById
{
    public class GetSubcategoryByIdQueryHandler : IRequestHandler<GetSubcategoryByIdQueryRequest, GetSubcategoryByIdQueryResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrieverService;
        private readonly IMapper _mapper;

        public GetSubcategoryByIdQueryHandler(ISubcategoryRetrievalService subcategoryRetrieverService, IMapper mapper)
        {
            _subcategoryRetrieverService = subcategoryRetrieverService;
            _mapper = mapper;
        }

        public Task<GetSubcategoryByIdQueryResponse> Handle(GetSubcategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _subcategoryRetrieverService.GetById(request.SubcategoryId);

            var response = _mapper.Map<Subcategory, GetSubcategoryByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
