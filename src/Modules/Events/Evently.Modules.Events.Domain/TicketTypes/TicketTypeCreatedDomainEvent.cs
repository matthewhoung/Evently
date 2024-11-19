using Evently.Common.Domain.Abstractions.DomainEvents;

namespace Evently.Modules.Events.Domain.TicketTypes;
public sealed partial class TicketType
{
    public sealed class TicketTypeCreatedDomainEvent(Guid ticketTypeId) : DomainEvent
    {
        public Guid TicketTypeId { get; init; } = ticketTypeId;
    }
}
