using AutoMapper;
using MediatR;
using Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged
{
    public class GetSubcategoriesPagedQueryHandler : IRequestHandler<GetSubcategoriesPagedQueryRequest, GetSubcategoriesPagedQueryResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrievalService;
        private readonly IMapper _mapper;

        public GetSubcategoriesPagedQueryHandler(ISubcategoryRetrievalService subcategoryRetrievalService, IMapper mapper)
        {
            _subcategoryRetrievalService = subcategoryRetrievalService;
            _mapper = mapper;
        }

        public Task<GetSubcategoriesPagedQueryResponse> Handle(GetSubcategoriesPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _subcategoryRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetSubcategoriesPagedQueryResponse
            {
                SubcategoryCount = serviceResult.Payload.Count,
                Subcategories = _mapper.Map<List<Subcategory>, List<GetSubcategoriesPaged_Subcategory>>(serviceResult.Payload),
                TotalPages = _subcategoryRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
