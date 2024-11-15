﻿using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Events;

public sealed class Event : Entity
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Location { get; private set; }
    public DateTime StartsAtUtc { get; private set; }
    public DateTime? EndsAtUtc { get; private set; }
    public EventStatus Status { get; private set; }

    private Event()
    {
        // Required by EF Core
    }

    public static Event Create(
        string title,
        string description,
        string location,
        DateTime startsAtUtc,
        DateTime? endsAtUtc)
    {
        var @event = new Event
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Location = location,
            StartsAtUtc = startsAtUtc,
            EndsAtUtc = endsAtUtc,
            Status = EventStatus.Draft
        };

        @event.Raise(new EventCreatedDomainEvent(@event.Id));

        return @event;
    }

    public Result Publish()
    {
        if (Status != EventStatus.Draft)
        {
            return Result.Failure(EventErrors.NotDraft);
        }

        Status = EventStatus.Published;

        Raise(new EventPublishedDomainEvent(Id));

        return Result.Success();
    }

    public void Reschedule(DateTime startsAtUtc, DateTime? endsAtUtc)
    {
        if (StartsAtUtc == startsAtUtc && EndsAtUtc == endsAtUtc)
        {
            return;
        }

        StartsAtUtc = startsAtUtc;
        EndsAtUtc = endsAtUtc;

        Raise(new EventRescheduledDomainEvent(Id, StartsAtUtc, EndsAtUtc));
    }

    public Result Cancel(DateTime utcNow)
    {
        if (Status == EventStatus.Cancelled)
        {
            return Result.Failure(EventErrors.AlreadyCanceled);
        }

        if (StartsAtUtc < utcNow)
        {
            return Result.Failure(EventErrors.AlreadyStarted);
        }

        Status = EventStatus.Cancelled;

        Raise(new EventCanceledDomainEvent(Id));

        return Result.Success();
    }
}