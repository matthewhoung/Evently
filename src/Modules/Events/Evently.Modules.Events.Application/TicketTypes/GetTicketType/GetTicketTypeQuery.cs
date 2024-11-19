using Evently.Common.Application.Abstractions.Messaging;

namespace Evently.Modules.Events.Application.TicketTypes.GetTicketType;
public sealed record GetTicketTypeQuery(Guid TicketTypeId) : IQuery<TicketTypeResponse>;
