using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Subcategories.Commands.SubcategoryAdd;
using Tuber.Application.Subcategories.Commands.SubcategoryDelete;
using Tuber.Application.Subcategories.Commands.SubcategoryUpdate;
using Tuber.Application.Subcategories.Queries.SubcategoriesGetPaged;
using Tuber.Application.Subcategories.Queries.SubcategoryGetById;
using Tuber.Domain.Exceptions;

namespace Tuber.API.Categories;

public static class SubcategoryEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/Subcategory/add", async (SubcategoryAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<SubcategoryAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<SubcategoryAddAPIRequest, SubcategoryAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<SubcategoryAddCommandResponse, SubcategoryAddAPIResponse>(queryResponse);

            return Results.Created($"/Subcategory/{apiResponse.SubcategoryId}", apiResponse);
        })
        .WithName("SubcategoryAdd");


        app.MapPut("/Subcategory/update", async (SubcategoryUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<SubcategoryUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<SubcategoryUpdateAPIRequest, SubcategoryUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<SubcategoryUpdateCommandResponse, SubcategoryUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/Subcategory/{apiResponse.SubcategoryId}", apiResponse);
        })
        .WithName("SubcategoryUpdate");



        app.MapDelete("/Subcategory/delete/{SubcategoryId}", async (Guid SubcategoryId,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new SubcategoryDeleteCommandRequest
            {
                SubcategoryId = SubcategoryId,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("SubcategoryDelete");
    }


    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/Subcategory/get", async (int pageNumber, int pageSize,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new SubcategoriesGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<SubcategoriesGetPagedQueryResponse, SubcategoriesGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("SubcategoriesGetPaged");


        app.MapGet("/Subcategory/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new SubcategoryGetByIdQueryRequest
            {
                SubcategoryId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<SubcategoryGetByIdQueryResponse, SubcategoryGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("SubcategoryGetById");
    }
}
