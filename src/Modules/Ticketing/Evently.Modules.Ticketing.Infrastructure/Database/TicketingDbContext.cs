using Evently.Modules.Ticketing.Application.Abstractions.Data;
using Evently.Modules.Ticketing.Domain.Custormers;
using Evently.Modules.Ticketing.Domain.Events;
using Evently.Modules.Ticketing.Infrastructure.Custormers;
using Evently.Modules.Ticketing.Infrastructure.Events;
using Microsoft.EntityFrameworkCore;

namespace Evently.Modules.Ticketing.Infrastructure.Database;
public sealed class TicketingDbContext(DbContextOptions<TicketingDbContext> options)
    : DbContext(options), IUnitOfWork
{
    internal DbSet<Customer> Customers { get; set; }
    internal DbSet<Event> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.Ticketing);

        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new EventConfiguration());
    }
}
