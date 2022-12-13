using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Imports.Commands.ImportAdd;
using Tuber.BLL.Imports.Queries.GetImportByBankAccountId;

namespace Tuber.API.Banks;

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
        .WithName("AddImport");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/import/get/{bankAccountId}", async (Guid bankAccountId,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetImportByBankAccountIdQueryRequest
            {
                BankAccountId = bankAccountId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetImportByBankAccountIdQueryResponse, GetImportByBankAccountIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetImportByBankAccountId");
    }
}
