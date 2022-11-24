using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.Domain.Exceptions;

namespace Tuber.API.Banks;

public static class ImportExtensions
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/import/add", async (AddImportAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<AddImportAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<AddImportAPIRequest, AddImportCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<AddImportCommandResponse, AddImportAPIResponse>(queryResponse);

            return Results.Created($"/import/{apiResponse.ImportId}", apiResponse);
        })
        .WithName("AddImport");
    }

    //public static void QueryEndpoints(WebApplication app)
    //{
    //    app.MapGet("/import/get", async (int pageNumber, int pageSize,
    //        [FromServices] IMediator mediator,
    //        [FromServices] IMapper mapper) =>
    //    {
    //        if (pageNumber < 1)
    //            return Results.BadRequest(new InvalidPageNumberException(pageNumber));

    //        if (pageSize < 1)
    //            return Results.BadRequest(new InvalidPageSizeException(pageSize));

    //        // Call query handler. This first invokes the pipeline behaviour.
    //        var queryResponse = await mediator.Send(new GetImportPagedQueryRequest
    //        {
    //            PageNumber = pageNumber,
    //            PageSize = pageSize
    //        });

    //        if (queryResponse.HasExceptions)
    //            return Results.BadRequest(queryResponse.Exceptions);

    //        //  Map Handler response to API Response and return.
    //        var apiResponse = mapper.Map<GetImportPagedQueryResponse, GetImportPagedAPIResponse>(queryResponse);

    //        return Results.Ok(apiResponse);
    //    })
    //    .WithName("GetImport");
    //}
}
