using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Ticketing.Application.Tickets.GetTicket;

public sealed record GetTicketQuery(Guid TicketId) : IQuery<TicketResponse>;

public sealed record TicketResponse(
    Guid Id,
    Guid CustomerId,
    Guid OrderId,
    Guid EventId,
    Guid TicketTypeId,
    string Code,
    DateTime CreatedAtUtc);
