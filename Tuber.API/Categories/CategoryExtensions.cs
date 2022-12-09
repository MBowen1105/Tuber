using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Categories.Commands.AddCategory;
using Tuber.BLL.Categories.Queries.GetCategoriesPaged;
using Tuber.Domain.Exceptions;

namespace Tuber.API.Categories;

public static class CategoryExtensions
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/category/add", async (AddCategoryAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<AddCategoryAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<AddCategoryAPIRequest, AddCategoryCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<AddCategoryCommandResponse, AddCategoryAPIResponse>(queryResponse);

            return Results.Created($"/category/{apiResponse.CategoryId}", apiResponse);
        })
        .WithName("AddCategory");


        //    app.MapPut("/Category/update", async (UpdateCategoryAPIRequest APIRequest,
        //        [FromServices] IMediator mediator,
        //        [FromServices] IMapper mapper,
        //        [FromServices] IEnumerable<IValidator<UpdateCategoryAPIRequest>> validators) =>
        //    {
        //        //  Map validated API request to query
        //        var query = mapper.Map<UpdateCategoryAPIRequest, UpdateCategoryCommandRequest>(APIRequest);

        //        // Call query handler. This first invokes the pipeline behaviour.
        //        var queryResponse = await mediator.Send(query);

        //        if (queryResponse.HasExceptions)
        //            return Results.BadRequest(queryResponse.Exceptions);

        //        //  Map Handler response to API Response and return.
        //        var apiResponse = mapper.Map<UpdateCategoryCommandResponse, UpdateCategoryAPIResponse>(queryResponse);

        //        return Results.Accepted($"/category/{apiResponse.Id}", apiResponse);
        //    })
        //    .WithName("UpdateCategory");



        //    app.MapDelete("/category/delete/{id}", async (Guid id,
        //        [FromServices] IMediator mediator) =>
        //    {
        //        // Call query handler. This first invokes the pipeline behaviour.
        //        var queryResponse = await mediator.Send(new DeleteCategoryCommandRequest
        //        {
        //            Id = id,
        //        });

        //        if (queryResponse.HasExceptions)
        //            return Results.BadRequest(queryResponse.Exceptions);

        //        return Results.NoContent();
        //    })
        //    .WithName("DeleteCategory");
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
            var queryResponse = await mediator.Send(new GetCategoriesPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetCategoriesPagedQueryResponse, GetCategoriesPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetCategories");


        //app.MapGet("/category/get/{id}", async (Guid id,
        //    [FromServices] IMediator mediator,
        //    [FromServices] IMapper mapper) =>
        //{
        //    // Call query handler. This first invokes the pipeline behaviour.
        //    var queryResponse = await mediator.Send(new GetCategoryByIdQueryRequest
        //    {
        //        CategoryId = id
        //    });

        //    if (queryResponse.HasExceptions)
        //        return Results.BadRequest(queryResponse.Exceptions);

        //    //  Map Handler response to API Response and return.
        //    var apiResponse = mapper.Map<GetCategoryByIdQueryResponse, GetCategoryByIdAPIResponse>(queryResponse);

        //    return Results.Ok(apiResponse);
        //})
        //.WithName("GetCategoryById");
    }
}
