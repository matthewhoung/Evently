using Evently.Common.Application.Abstractions.Messaging;
using Evently.Modules.Ticketing.Application.Tickets.GetTicket;

namespace Evently.Modules.Ticketing.Application.Tickets.GetTicketByCode;

public sealed record GetTicketByCodeQuery(string Code) : IQuery<TicketResponse>;
