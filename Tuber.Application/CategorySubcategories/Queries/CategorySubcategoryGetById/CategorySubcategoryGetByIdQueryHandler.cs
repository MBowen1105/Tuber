using AutoMapper;
using MediatR;
using Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.Application.CategorySubcategorys.Queries.CategorySubcategoryGetById
{
    public class CategorySubcategoryGetByIdQueryHandler : IRequestHandler<CategorySubcategoryGetByIdQueryRequest, CategorySubcategoryGetByIdQueryResponse>
    {
        private readonly ICategorySubcategoryRetrievalService _categorySubcategoryRetrieverService;
        private readonly IMapper _mapper;

        public CategorySubcategoryGetByIdQueryHandler(ICategorySubcategoryRetrievalService categorySubcategoryRetrieverService, IMapper mapper)
        {
            _categorySubcategoryRetrieverService = categorySubcategoryRetrieverService;
            _mapper = mapper;
        }

        public Task<CategorySubcategoryGetByIdQueryResponse> Handle(CategorySubcategoryGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _categorySubcategoryRetrieverService.GetById(request.CategorySubcategoryId);

            var response = _mapper.Map<CategorySubcategory, CategorySubcategoryGetByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
