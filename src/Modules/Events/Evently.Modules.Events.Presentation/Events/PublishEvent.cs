﻿using Evently.Common.Domain.Abstractions.Results;
using Evently.Common.Presentation.EndPoints;
using Evently.Modules.Events.Application.Events.PublishEvent;
using Evently.Modules.Events.Presentation.ApiResults;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Events;

internal class PublishEvent : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("events/{id}/publish", async (Guid id, ISender sender) =>
        {
            Result result = await sender.Send(new PublishEventCommand(id));

            return result.Match(Results.NoContent, ApiResults.ApiResults.Problem);
        })
        .WithTags(Tags.Events);
    }
}
