using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Exceptions;
using Tuber.Application.Institutions.Commands.InstitutionAdd;
using Tuber.Application.Institutions.Commands.InstitutionDelete;
using Tuber.Application.Institutions.Commands.InstitutionUpdate;
using Tuber.Application.Institutions.Queries.InstitutionGetById;
using Tuber.Application.Institutions.Queries.InstitutionGetPaged;

namespace Tuber.API.Institutions;

public static class InstitutionEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/institution/add", async (InstitutionAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<InstitutionAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<InstitutionAddAPIRequest, InstitutionAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionAddCommandResponse, InstitutionAddAPIResponse>(queryResponse);

            return Results.Created($"/institution/{apiResponse.InstitutionId}", apiResponse);
        })
        .WithName("InstitutionAdd");


        app.MapPut("/institution/update", async (InstitutionUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<InstitutionUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<InstitutionUpdateAPIRequest, InstitutionUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionUpdateCommandResponse, InstitutionUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/institution/{apiResponse.InstitutionId}", apiResponse);
        })
        .WithName("InstitutionUpdate");



        app.MapDelete("/institution/delete/{id}", async (Guid id,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new InstitutionDeleteCommandRequest
            {
                InstitutionId = id,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("InstitutionDelete");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/institution/get", async (int pageNumber, int pageSize,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new InstitutionGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionGetPagedQueryResponse, InstitutionGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("InstitutionsGetPaged");


        app.MapGet("/institution/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new InstitutionGetByIdQueryRequest
            {
                InstitutionId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionGetByIdQueryResponse, InstitutionGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("InstitutionGetById");
    }
}
