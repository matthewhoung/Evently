using Evently.Common.Application.Abstractions.Messaging;
using Evently.Modules.Ticketing.Application.Tickets.GetTicket;

namespace Evently.Modules.Ticketing.Application.Tickets.GetTicketForOrder;

public sealed record GetTicketsForOrderQuery(Guid OrderId) : IQuery<IReadOnlyCollection<TicketResponse>>;
