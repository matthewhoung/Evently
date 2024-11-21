﻿using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Modules.Ticketing.Domain.Orders;
public sealed class OrderTicketsIssuedDomainEvent(Guid orderId) : DomainEvent
{
    public Guid OrderId { get; init; } = orderId;
}

