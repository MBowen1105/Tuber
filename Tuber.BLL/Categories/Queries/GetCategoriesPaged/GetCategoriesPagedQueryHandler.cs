using AutoMapper;
using MediatR;
using Tuber.Domain.Dtos;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories.Queries.GetCategoriesPaged
{
    public class GetCategoriesPagedQueryHandler : IRequestHandler<GetCategoriesPagedQueryRequest, GetCategoriesPagedQueryResponse>
    {
        private readonly ICategoryRetrievalService _categoryRetrievalService;
        private readonly IMapper _mapper;

        public GetCategoriesPagedQueryHandler(ICategoryRetrievalService categoryRetrievalService, IMapper mapper)
        {
            _categoryRetrievalService = categoryRetrievalService;
            _mapper = mapper;
        }

        public Task<GetCategoriesPagedQueryResponse> Handle(GetCategoriesPagedQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categoryRetrievalService.GetPaged(request.PageNumber, request.PageSize);

            var response = new GetCategoriesPagedQueryResponse
            {
                CategoryCount = serviceResult.Payload.Count,
                Categories = _mapper.Map<List<Category>, List<GetCategoriesPaged_Category>>(serviceResult.Payload),
                TotalPages = _categoryRetrievalService.CountPages(request.PageSize)
            };

            return Task.FromResult(response);
        }
    }
}
