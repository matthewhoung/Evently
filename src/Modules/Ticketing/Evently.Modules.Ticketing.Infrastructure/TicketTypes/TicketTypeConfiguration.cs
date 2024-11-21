using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Evently.Modules.Ticketing.Domain.TicketTypes;
using Evently.Modules.Ticketing.Domain.Events;

namespace Evently.Modules.Ticketing.Infrastructure.TicketTypes;
internal sealed class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
{
    public void Configure(EntityTypeBuilder<TicketType> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasOne<Event>().WithMany().HasForeignKey(t => t.EventId);
    }
}
