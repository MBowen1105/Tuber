using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Dtos;
using Tuber.Application.Models;

namespace Tuber.Application.Subcategories.Queries.SubcategoriesGetPaged
{
    public class SubcategoriesGetPagedQueryHandler : IRequestHandler<SubcategoriesGetPagedQueryRequest, SubcategoriesGetPagedQueryResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrievalService;
        private readonly IMapper _mapper;

        public SubcategoriesGetPagedQueryHandler(ISubcategoryRetrievalService subcategoryRetrievalService, IMapper mapper)
        {
            _subcategoryRetrievalService = subcategoryRetrievalService;
            _mapper = mapper;
        }

        public Task<SubcategoriesGetPagedQueryResponse> Handle(SubcategoriesGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _subcategoryRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new SubcategoriesGetPagedQueryResponse
            {
                SubcategoryCount = serviceResult.Payload.Count,
                Subcategories = _mapper.Map<List<Subcategory>, List<GetSubcategoriesPaged_Subcategory>>(serviceResult.Payload),
                TotalPages = _subcategoryRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
