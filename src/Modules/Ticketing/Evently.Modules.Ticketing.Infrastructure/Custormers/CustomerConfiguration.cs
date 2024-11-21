using Evently.Modules.Ticketing.Domain.Custormers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Evently.Modules.Ticketing.Infrastructure.Custormers;
internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.FirstName).HasMaxLength(50);

        builder.Property(c => c.LastName).HasMaxLength(50);

        builder.Property(c => c.Email).HasMaxLength(100);

        builder.HasIndex(c => c.Email).IsUnique();
    }
}
