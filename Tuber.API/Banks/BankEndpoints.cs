using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Banks.Commands.AddBank;
using Tuber.Application.Banks.Commands.BankAdd;
using Tuber.Application.Banks.Commands.BankDelete;
using Tuber.Application.Banks.Commands.BankUpdate;
using Tuber.Application.Banks.Queries.BankGetById;
using Tuber.Application.Banks.Queries.BankGetPaged;
using Tuber.Domain.Exceptions;

namespace Tuber.API.Banks;

public static class BankEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/bank/add", async (BankAddAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<BankAddAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<BankAddAPIRequest, BankAddCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankAddCommandResponse, BankAddAPIResponse>(queryResponse);

            return Results.Created($"/bank/{apiResponse.BankId}", apiResponse);
        })
        .WithName("BankAdd");


        app.MapPut("/bank/update", async (BankUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<BankUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<BankUpdateAPIRequest, BankUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankUpdateCommandResponse, BankUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/bank/{apiResponse.Id}", apiResponse);
        })
        .WithName("BankUpdate");



        app.MapDelete("/bank/delete/{id}", async (Guid id,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankDeleteCommandRequest
            {
                BankId = id,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("BankDelete");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/bank/get", async (int pageNumber, int pageSize,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankGetPagedQueryResponse, BankGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("BanksGetPaged");


        app.MapGet("/bank/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankGetByIdQueryRequest
            {
                BankId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankGetByIdQueryResponse, BankGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("BankGetById");
    }
}
