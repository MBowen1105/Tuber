using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.BLL.Imports.Queries;

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
