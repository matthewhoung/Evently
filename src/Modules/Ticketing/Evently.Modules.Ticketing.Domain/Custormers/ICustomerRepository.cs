namespace Evently.Modules.Ticketing.Domain.Custormers;
public interface ICustomerRepository
{
    Task<Custormer?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Custormer custormer);
}
