using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Ledgers.Queries.LedgerGetPaged;

namespace Tuber.API.Ledgers;

public static class LedgerEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapPut("/ledger/get", async (LedgerGetPagedAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new LedgerGetPagedQueryRequest
            {
                BankAccountId = APIRequest.BankAccountId,
                PageNumber = APIRequest.PageNumber,
                PageSize = APIRequest.PageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<LedgerGetPagedQueryResponse, LedgerGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("LedgerGetPaged");
    }
}
