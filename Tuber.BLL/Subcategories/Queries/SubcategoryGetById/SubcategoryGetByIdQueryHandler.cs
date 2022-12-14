﻿using AutoMapper;
using MediatR;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Queries.SubcategoryGetById
{
    public class SubcategoryGetByIdQueryHandler : IRequestHandler<SubcategoryGetByIdQueryRequest, SubcategoryGetByIdQueryResponse>
    {
        private readonly ISubcategoryRetrievalService _subcategoryRetrieverService;
        private readonly IMapper _mapper;

        public SubcategoryGetByIdQueryHandler(ISubcategoryRetrievalService subcategoryRetrieverService, IMapper mapper)
        {
            _subcategoryRetrieverService = subcategoryRetrieverService;
            _mapper = mapper;
        }

        public Task<SubcategoryGetByIdQueryResponse> Handle(SubcategoryGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _subcategoryRetrieverService.GetById(request.SubcategoryId);

            var response = _mapper.Map<Subcategory, SubcategoryGetByIdQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}