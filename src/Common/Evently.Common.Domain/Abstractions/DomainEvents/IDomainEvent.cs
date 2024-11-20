﻿using MediatR;

namespace Evently.Common.Domain.Abstractions.DomainEvents;
public interface IDomainEvent : INotification
{
    Guid Id { get; }
    DateTime OccurredOnUtc { get; }
}
