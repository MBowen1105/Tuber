using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Subcategories.Commands.SubcategoryAdd;
using Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
using Tuber.BLL.Subcategories.Queries.GetSubcategoryById;
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
        .WithName("AddSubcategory");


        //app.MapPut("/Subcategory/update", async (UpdateSubcategoryAPIRequest APIRequest,
        //    [FromServices] IMediator mediator,
        //    [FromServices] IMapper mapper,
        //    [FromServices] IEnumerable<IValidator<UpdateSubcategoryAPIRequest>> validators) =>
        //{
        //    //  Map validated API request to query
        //    var query = mapper.Map<UpdateSubcategoryAPIRequest, UpdateSubcategoryCommandRequest>(APIRequest);

        //    // Call query handler. This first invokes the pipeline behaviour.
        //    var queryResponse = await mediator.Send(query);

        //    if (queryResponse.HasExceptions)
        //        return Results.BadRequest(queryResponse.Exceptions);

        //    //  Map Handler response to API Response and return.
        //    var apiResponse = mapper.Map<UpdateSubcategoryCommandResponse, UpdateSubcategoryAPIResponse>(queryResponse);

        //    return Results.Accepted($"/Subcategory/{apiResponse.SubcategoryId}", apiResponse);
        //})
        //.WithName("UpdateSubcategory");



        //app.MapDelete("/Subcategory/delete/{SubcategoryId}", async (Guid SubcategoryId,
        //    [FromServices] IMediator mediator) =>
        //{
        //    // Call query handler. This first invokes the pipeline behaviour.
        //    var queryResponse = await mediator.Send(new DeleteSubcategoryCommandRequest
        //    {
        //        SubcategoryId = SubcategoryId,
        //    });

        //    if (queryResponse.HasExceptions)
        //        return Results.BadRequest(queryResponse.Exceptions);

        //    return Results.NoContent();
        //})
        //.WithName("DeleteSubcategory");
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
            var queryResponse = await mediator.Send(new GetSubcategoriesPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetSubcategoriesPagedQueryResponse, GetSubcategoriesPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetSubcategories");


        app.MapGet("/Subcategory/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetSubcategoryByIdQueryRequest
            {
                SubcategoryId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetSubcategoryByIdQueryResponse, GetSubcategoryByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetSubcategoryById");
    }
}
