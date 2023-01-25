using AutoMapper;
using AutoMapper.Internal;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.Banks.Commands.BankAdd;
using Tuber.Application.Ledgers.Commands.LedgerAddCredit;
using Tuber.Application.Ledgers.Commands.LedgerAddDebit;
using Tuber.Application.Ledgers.Commands.LedgerAddTransferOut;
using Tuber.Application.Ledgers.Queries.LedgerGetPaged;

namespace Tuber.API.Ledgers;

public static class LedgerEndpoints
{

    #region "Command Endpoints"
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/ledger/addcredit", async (LedgerAddCreditAPIRequest APIRequest,
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper,
                [FromServices] IEnumerable<IValidator<LedgerAddCreditAPIRequest>> validators) =>
            {
                //  Map API request to query
                var query = mapper.Map<LedgerAddCreditAPIRequest, LedgerAddCreditCommandRequest>(APIRequest);

                // Call query handler. This first invokes the pipeline behaviour.
                var queryResponse = await mediator.Send(query);

                if (queryResponse.HasExceptions)
                    return Results.BadRequest(queryResponse.Exceptions);

                //  Map Handler response to API Response and return.
                var apiResponse = mapper.Map<LedgerAddCreditCommandResponse, LedgerAddCreditAPIResponse>(queryResponse);

                return Results.Created($"/ledger/{apiResponse.LedgerId}", apiResponse);
            })
            .WithName("LedgerAddCredit");

        app.MapPut("/ledger/adddebit", async (LedgerAddDebitAPIRequest APIRequest,
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper,
                [FromServices] IEnumerable<IValidator<LedgerAddDebitAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<LedgerAddDebitAPIRequest, LedgerAddDebitCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<LedgerAddDebitCommandResponse, LedgerAddDebitAPIResponse>(queryResponse);

            return Results.Created($"/ledger/{apiResponse.LedgerId}", apiResponse);
        })
            .WithName("LedgerAddDebit");

        app.MapPut("/ledger/addtransferout", async (LedgerAddTransferOutAPIRequest APIRequest,
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper,
                [FromServices] IEnumerable<IValidator<LedgerAddTransferOutAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<LedgerAddTransferOutAPIRequest, LedgerAddTransferOutCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<LedgerAddTransferOutCommandResponse, LedgerAddTransferOutAPIResponse>(queryResponse);

            return Results.Created($"/ledger/{apiResponse.LedgerId}", apiResponse);
        })
            .WithName("LedgerAddTransferOut");
    }
    #endregion

    #region "Query Endpoints"
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
    #endregion
}
