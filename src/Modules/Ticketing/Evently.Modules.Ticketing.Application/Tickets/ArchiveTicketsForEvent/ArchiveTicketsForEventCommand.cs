using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Ticketing.Application.Tickets.ArchiveTicketsForEvent;

public sealed record ArchiveTicketsForEventCommand(Guid EventId) : ICommand;

internal sealed class ArchiveTicketsForEventCommandValidator : AbstractValidator<ArchiveTicketsForEventCommand>
{
    public ArchiveTicketsForEventCommandValidator()
    {
        RuleFor(c => c.EventId).NotEmpty();
    }
}

