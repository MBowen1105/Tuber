using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryAdd;
using Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryDelete;
using Tuber.BLL.Subcategories.Commands.SubcategoryAdd;

namespace Tuber.API.CategoriesSubcategories;

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

            return Results.Created($"/CategorySubcategory/{apiResponse.SubcategoryId}", apiResponse);
        })
        .WithName("CategorySubcategoryAdd");


        app.MapDelete("/CategorySubcategory/delete/{categorySubcategoryId}", async (Guid categorySubcategoryId,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new CategorySubcategoryDeleteCommandRequest
            {
                CategorySubcategoryId = categorySubcategoryId,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("CategorySubcategoryDelete");
    }
}
