using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.BankAccounts.Commands.BankAccountUpdate;
using Tuber.Application.BankAccounts.Queries.BankAccountGetById;
using Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Application.Exceptions;

namespace Tuber.API.BankAccounts;

public static class BankAccountEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/bankaccount/update", async (BankAccountUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<BankAccountUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<BankAccountUpdateAPIRequest, BankAccountUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankAccountUpdateCommandResponse, BankAccountUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/bankAccount/{apiResponse.BankAccountId}", apiResponse);
        })
        .WithName("BankAccountUpdate");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/bankAccount/get", async (int pageNumber, int pageSize,
        [FromServices] IMediator mediator,
        [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankAccountGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankAccountGetPagedQueryResponse, BankAccountGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
    .WithName("BankAccountsGetPaged");


        app.MapGet("/bankAccount/get/{id}", async (Guid bankAccountId,
        [FromServices] IMediator mediator,
        [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankAccountGetByIdQueryRequest
            {
                BankAccountId = bankAccountId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankAccountGetByIdQueryResponse, BankAccountGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
            .WithName("BankAccountGetById");
    }
}