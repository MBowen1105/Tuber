using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountById;
using Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.Domain.Exceptions;

namespace Tuber.API.BankAccounts;

public static class BankAccountExtensions
{
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
        var queryResponse = await mediator.Send(new GetBankAccountPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        });

        if (queryResponse.HasExceptions)
            return Results.BadRequest(queryResponse.Exceptions);

        //  Map Handler response to API Response and return.
        var apiResponse = mapper.Map<GetBankAccountPagedQueryResponse, GetBankAccountPagedAPIResponse>(queryResponse);

        return Results.Ok(apiResponse);
    })
    .WithName("GetBankAccounts");
    
        
    app.MapGet("/bankAccount/get/{id}", async(Guid id,
    [FromServices] IMediator mediator,
    [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetBankAccountByIdQueryRequest
                {
                    BankAccountId = id
                });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetBankAccountByIdQueryResponse, GetBankAccountByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetBankAccountById");
    }

}