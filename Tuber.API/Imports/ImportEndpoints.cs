using AutoMapper;
using AutoMapper.Internal;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Imports.Commands.ImportAccept;
using Tuber.Application.Imports.Commands.ImportAdd;
using Tuber.Application.Imports.Commands.ImportUpdate;
using Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId;

namespace Tuber.API.Institutions;

public static class ImportEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/import/add", async (ImportAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<ImportAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<ImportAddAPIRequest, ImportAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportAddCommandResponse, ImportAddAPIResponse>(queryResponse);

            return Results.Created($"/import/", apiResponse);
        })
        .WithName("ImportAdd");


        app.MapPut("/import/update", async (ImportUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<ImportUpdateAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<ImportUpdateAPIRequest, ImportUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportUpdateCommandResponse, ImportUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/import/{apiResponse.ImportId}", apiResponse);
        })
        .WithName("ImportUpdate");


        app.MapPut("/import/accept/{bankAccountId}", async (Guid bankAccountId,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new ImportAcceptCommandRequest
            {
                InstitutionAccountId = bankAccountId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportAcceptCommandResponse, ImportAcceptAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("ImportAccept");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/import/get/{bankAccountId}", async (Guid bankAccountId,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new ImportGetByInstitutionAccountIdQueryRequest
            {
                InstitutionAccountId = bankAccountId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportGetByInstitutionAccountIdQueryResponse, ImportGetByInstitutionAccountIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("ImportGetByInstitutionAccountId");
    }
}
