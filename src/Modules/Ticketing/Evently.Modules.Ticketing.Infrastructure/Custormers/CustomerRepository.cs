using Evently.Modules.Ticketing.Domain.Custormers;

namespace Evently.Modules.Ticketing.Infrastructure.Custormers;
internal sealed class CustomerRepository(TicketingDbContext context) : ICustomerRepository
{
    public async Task<Custormer?> GetAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await context.Customers.SingleOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public void Insert(Custormer custormer)
    {
        throw new NotImplementedException();
    }
}
