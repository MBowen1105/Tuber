using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;

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
    }
}
