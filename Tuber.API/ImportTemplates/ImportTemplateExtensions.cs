using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;
using Tuber.Domain.Exceptions;

namespace Tuber.API.ImportTemplates;

public static class ImportTemplateExtensions
{
    public static void CommandEndpoints(WebApplication app)
    {
        
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/importTemplate/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetImportTemplateByIdQueryRequest
            {
                ImportTemplateId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetImportTemplateByIdQueryResponse, GetImportTemplateByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetImportTemplateById");


        app.MapGet("/importTemplate/get", async (int pageNumber, int pageSize,
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetImportTemplatePagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetImportTemplatePagedQueryResponse, GetImportTemplatePagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
            .WithName("GetImportTemplates");


    }
}
