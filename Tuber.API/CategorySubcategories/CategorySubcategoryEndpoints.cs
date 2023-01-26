using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;
using Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;
using Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryDelete;
using Tuber.Application.CategorySubcategories.Commands.InstitutionAdd;
using Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;

namespace Tuber.API.CategorySubcategories;

public static class CategorySubcategoryEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/CategorySubcategory/add", async (CategorySubcategoryAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<CategorySubcategoryAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<CategorySubcategoryAddAPIRequest, CategorySubcategoryAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategorySubcategoryAddCommandResponse, CategorySubcategoryAddAPIResponse>(queryResponse);

            return Results.Created($"/CategorySubcategory/{apiResponse.CategorySubcategoryId}", apiResponse);
        })
        .WithName("CategorySubcategoryAdd");


        app.MapDelete("/CategorySubcategory/delete/{CategorySubcategoryId}", async (Guid CategorySubcategoryId,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategorySubcategoryDeleteCommandRequest
            {
                CategorySubcategoryId = CategorySubcategoryId,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("CategorySubcategoryDelete");
    }


    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/CategorySubcategory/get/{categorySubcategoryId}", async (Guid categorySubcategoryId,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategorySubcategoryGetByIdQueryRequest
            {
                CategorySubcategoryId = categorySubcategoryId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<CategorySubcategoryGetByIdQueryResponse, CategorySubcategoryGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("CategorySubcategoryGetById");
    }
}
