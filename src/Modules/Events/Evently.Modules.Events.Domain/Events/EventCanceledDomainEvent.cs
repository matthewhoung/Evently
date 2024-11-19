﻿using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventCanceledDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; init; } = eventId;
}
