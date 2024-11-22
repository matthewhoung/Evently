using Evently.Modules.Users.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Evently.Modules.Users.Infrastructure.Users;
internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(key => key.Id);
        builder.HasIndex(ip => ip.IdentityId).IsUnique();
        builder.Property(e => e.Email).HasMaxLength(100);
        builder.HasIndex(e => e.Email).IsUnique();
        builder.Property(fn => fn.FirstName).HasMaxLength(50);
        builder.Property(ln => ln.LastName).HasMaxLength(50);
    }
}
