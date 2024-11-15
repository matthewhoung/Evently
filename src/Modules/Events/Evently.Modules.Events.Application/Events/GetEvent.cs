﻿using System.Data.Common;
using Dapper;
using Evently.Modules.Events.Application.Abstractions.Data;
using MediatR;

namespace Evently.Modules.Events.Application.Events;

public sealed record GetEventQuery(Guid EventId) : IRequest<EventResponse?>;

internal sealed class GetEventQueryHandler(IDbConnectionFactory dbConnectionFactory)
    : IRequestHandler<GetEventQuery, EventResponse?>
{
    public async Task<EventResponse?> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        await using DbConnection connection = await dbConnectionFactory.OpenConnectionAsync();

        const string sql =
        $"""
         SELECT
             e.id AS {nameof(EventResponse.Id)},
             e.category_id AS {nameof(EventResponse.CategoryId)},
             e.title AS {nameof(EventResponse.Title)},
             e.description AS {nameof(EventResponse.Description)},
             e.location AS {nameof(EventResponse.Location)},
             e.starts_at_utc AS {nameof(EventResponse.StartsAtUtc)},
             e.ends_at_utc AS {nameof(EventResponse.EndsAtUtc)},
             tt.id AS {nameof(TicketTypeResponse.TicketTypeId)},
             tt.name AS {nameof(TicketTypeResponse.Name)},
             tt.price AS {nameof(TicketTypeResponse.Price)},
             tt.currency AS {nameof(TicketTypeResponse.Currency)},
             tt.quantity AS {nameof(TicketTypeResponse.Quantity)}
         FROM events.events e
         LEFT JOIN events.ticket_types tt ON tt.event_id = e.id
         WHERE e.id = @EventId
         """;

        EventResponse? @event = await connection.QueryFirstOrDefaultAsync(sql, request);

        return @event;
    }
}
