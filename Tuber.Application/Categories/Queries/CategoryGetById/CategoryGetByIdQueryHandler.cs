using AutoMapper;
using MediatR;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.Application.Categories.Queries.CategoryGetById
{
    public class CategoryGetByIdQueryHandler : IRequestHandler<CategoryGetByIdQueryRequest, CategoryGetByIdQueryResponse>
    {
        private readonly ICategoryRetrievalService _categoryRetrievalService;
        private readonly IMapper _mapper;

        public CategoryGetByIdQueryHandler(ICategoryRetrievalService categoryRetrievalService, IMapper mapper)
        {
            _categoryRetrievalService = categoryRetrievalService;
            _mapper = mapper;
        }

        public Task<CategoryGetByIdQueryResponse> Handle(CategoryGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categoryRetrievalService.GetById(request.CategoryId);

            var response = _mapper.Map<Category, CategoryGetByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
