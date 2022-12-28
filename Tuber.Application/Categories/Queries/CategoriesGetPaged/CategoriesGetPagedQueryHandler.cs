using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Dtos;
using Tuber.Application.Models;

namespace Tuber.Application.Categories.Queries.CategoriesGetPaged
{
    public class CategoriesGetPagedQueryHandler : IRequestHandler<CategoriesGetPagedQueryRequest, CategoriesGetPagedQueryResponse>
    {
        private readonly ICategoryRetrievalService _categoryRetrievalService;
        private readonly IMapper _mapper;

        public CategoriesGetPagedQueryHandler(ICategoryRetrievalService categoryRetrievalService, IMapper mapper)
        {
            _categoryRetrievalService = categoryRetrievalService;
            _mapper = mapper;
        }

        public Task<CategoriesGetPagedQueryResponse> Handle(CategoriesGetPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categoryRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            return Task.FromResult(new CategoriesGetPagedQueryResponse
            {
                CategoryCount = serviceResult.Payload.Count,
                Categories = _mapper.Map<List<Category>, List<GetCategoriesPaged_Category>>(serviceResult.Payload),
                TotalPages = _categoryRetrievalService.CountPages(request.PageSize)
            });
        }
    }
}
