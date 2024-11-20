﻿using Evently.Common.Domain.Abstractions.DomainEvents;
using MediatR;

namespace Evently.Common.Application.Abstractions.Messaging;

public interface IDomainEventHandler<in TDomainEvent>
    : INotificationHandler<TDomainEvent> 
    where TDomainEvent : IDomainEvent;
