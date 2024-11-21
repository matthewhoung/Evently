﻿namespace Evently.Modules.Ticketing.Domain.TicketTypes;
public interface ITicketTypeRepository
{
    Task<TicketType?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    Task<TicketType?> GetWithLockAsync(Guid id, CancellationToken cancellationToken = default);

    void InsertRange(IEnumerable<TicketType> ticketTypes);
}