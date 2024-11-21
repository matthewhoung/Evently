﻿using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Modules.Ticketing.Domain.Tickets;
public sealed class TicketArchivedDomainEvent(Guid ticketId, string code) : DomainEvent
{
    public Guid TicketId { get; init; } = ticketId;

    public string Code { get; init; } = code;
}