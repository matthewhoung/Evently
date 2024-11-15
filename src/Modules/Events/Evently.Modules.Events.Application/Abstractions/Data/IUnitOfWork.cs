namespace Evently.Modules.Events.Application.Abstractions.Data;

// IUnitOfWork interface for efcore to communicate with the database
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
