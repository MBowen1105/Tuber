﻿using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Categories.Commands.CategoryAdd;
using Tuber.Application.Categories.Commands.CategoryDelete;
using Tuber.Application.Categories.Commands.CategoryUpdate;
using Tuber.Application.Categories.Queries.CategoriesGetPaged;
using Tuber.Application.Categories.Queries.CategoryGetById;
using Tuber.Application.Categorys.Queries.CategoryGetById;
using Tuber.Application.Exceptions;

namespace Tuber.API.Categories;

public static class CategoryEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/category/add", async (CategoryAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<CategoryAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<CategoryAddAPIRequest, CategoryAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategoryAddCommandResponse, CategoryAddAPIResponse>(queryResponse);

            return Results.Created($"/category/{apiResponse.CategoryId}", apiResponse);
        })
        .WithName("CategoryAdd");


        app.MapPut("/Category/update", async (CategoryUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<CategoryUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<CategoryUpdateAPIRequest, CategoryUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategoryUpdateCommandResponse, CategoryUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/category/{apiResponse.CategoryId}", apiResponse);
        })
        .WithName("CategoryUpdate");



        app.MapDelete("/category/delete/{categoryId}", async (Guid categoryId,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategoryDeleteCommandRequest
            {
                CategoryId = categoryId,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("CategoryDelete");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/category/get", async (int pageNumber, int pageSize,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategoriesGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategoriesGetPagedQueryResponse, CategoriesGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("CategoriesGetPaged");


        app.MapGet("/category/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategoryGetByIdQueryRequest
            {
                CategoryId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategoryGetByIdQueryResponse, CategoryGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("CategoryGetById");
    }
}
