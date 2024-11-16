﻿using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.TicketTypes;
public sealed partial class TicketType
{
    public sealed class TicketTypeCreatedDomainEvent(Guid ticketTypeId) : DomainEvent
    {
        public Guid TicketTypeId { get; init; } = ticketTypeId;
    }
}