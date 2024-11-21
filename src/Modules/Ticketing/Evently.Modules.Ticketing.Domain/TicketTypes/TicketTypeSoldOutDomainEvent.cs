using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Modules.Ticketing.Domain.TicketTypes;
public sealed class TicketTypeSoldOutDomainEvent(Guid ticketTypeId) : DomainEvent
{
    public Guid TicketTypeId { get; init; } = ticketTypeId;
}
