﻿using Evently.Common.Domain.Abstractions.Results;
using Evently.Common.Presentation.EndPoints;
using Evently.Modules.Events.Presentation.ApiResults;
using Evently.Modules.Ticketing.Application.Tickets.GetTicket;
using Evently.Modules.Ticketing.Application.Tickets.GetTicketForOrder;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Ticketing.Presentation.Tickets;

internal sealed class GetTicketsForOrder : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("tickets/order/{orderId}", async (Guid orderId, ISender sender) =>
        {
            Result<IReadOnlyCollection<TicketResponse>> result = await sender.Send(
                new GetTicketsForOrderQuery(orderId));

            return result.Match(Results.Ok, ApiResults.Problem);
        })
        .RequireAuthorization()
        .WithTags(Tags.Tickets);
    }
}
